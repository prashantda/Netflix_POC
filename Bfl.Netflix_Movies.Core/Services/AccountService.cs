using AutoMapper;
using Bfl.Netflix.Core.Domain.Entities;
using Bfl.Netflix.Core.Domain.RepositoryContracts;
using Bfl.Netflix.Core.Enums;
using Bfl.Netflix.Core.Helpers;
using Bfl.Netflix.Core.ServiceContracts;
using Bfl.Netflix_Movies.Core.DTO.Accounts;
using Bfl.Netflix_Service1.Core.DTO.Accounts;
using Bfl.Netflix_Service1.Core.DTO.Shared;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Bfl.Netflix.Core.Services
{
    public class AccountService : IAccountService
    {
        private readonly IMapper _mapper;
        private readonly UserManager<ApplicationUser> _userManager;
       //private readonly RoleManager<ApplicationRole> _roleManager;
        private readonly ILogger<AccountService> _logger;
        private readonly IConfiguration _configuration;
        private readonly IOtpRepository _otpRepository;
        public AccountService(IConfiguration configuration,IMapper mapper, UserManager<ApplicationUser> userManager, ILogger<AccountService> logger,IOtpRepository otpRepository)
        {
            _mapper = mapper;
            _userManager = userManager;
            _logger = logger;
            _configuration = configuration;
            _otpRepository = otpRepository;
        }
    
        public async Task<RegisterResponse> RegisterUser(RegisterRequest registerRequest)
        {
            if(registerRequest == null)
            {
                throw new ArgumentException($"{nameof(registerRequest)} is null in Account controller RegisterUser method");
            }
            var user = await _userManager.FindByEmailAsync(registerRequest.Email);
            if(user != null)
            {
                throw new ApplicationException("User Alrady Present");
            }
            ApplicationUser applicationUser = _mapper.Map<ApplicationUser>(registerRequest);
            applicationUser.Subscription = "Customer";
            var result = await _userManager.CreateAsync(applicationUser, Guid.NewGuid().ToString());
            OneTimePassword oneTimePassword=null;
            RegisterResponse registerResponse = null;
            if (result.Succeeded)
            {
                await _userManager.AddToRoleAsync(applicationUser, "Customer");
                int otp=  await MailHelper.SendMail(registerRequest.Email, null, null);
                var resetToken=await _userManager.GeneratePasswordResetTokenAsync(applicationUser);
                 oneTimePassword = new OneTimePassword() {
                    ApplicationUserId=applicationUser.Id,OTP=otp,CreatedAt=DateTime.Now,TempUserId= Guid.NewGuid() ,ResetToken=resetToken
                 };
                 oneTimePassword= await  _otpRepository.AddAsync(oneTimePassword);
                registerResponse = _mapper.Map<RegisterResponse>(applicationUser);
                registerResponse.ResetToken = oneTimePassword.ResetToken;
                registerResponse.CreatedAt = oneTimePassword.CreatedAt;
                registerResponse.TempUserid = oneTimePassword.TempUserId;
            }
             
            return registerResponse;
        }

        public async Task<SignInResponse> SignIn(SignInRequest signInRequest)
        {
            
           if (signInRequest == null || signInRequest.Email==null ||signInRequest.Password==null)
            {
                throw new ArgumentNullException("Username or Password is null");
            }
          var user=await  _userManager.FindByEmailAsync(signInRequest.Email);
            var isValid = _userManager.CheckPasswordAsync(user, signInRequest.Password);
            if(user == null || !isValid.Result)
            {
                throw new Exception("User doesn't exist");
            }
            return new SignInResponse() 
            {
                /*Id = user.Id,*/Username=user.Email,Token= await GenerateToken(user)
             };

        }

        public async Task<bool> UpdateSubscription(SubscriptionRequest subscriptionRequest)
        {
          var user= await _userManager.FindByIdAsync(subscriptionRequest.CustomerId.ToString());
            var subscription = Enum.Parse<Subscription>(subscriptionRequest.Amount.ToString());
            user.Subscription = subscription.ToString();
          var result= await _userManager.UpdateAsync(user);
            
            if (result.Succeeded)
            {
                await _userManager.RemoveFromRoleAsync(user, user.Subscription);
                await _userManager.AddToRoleAsync(user, subscription.ToString());
                return true;
            }
            return false;
        }
       
        public async Task<string> GenerateToken(ApplicationUser user)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JwtSettings:Key"]));
            var credentials=new SigningCredentials(securityKey,SecurityAlgorithms.HmacSha256);
            var roles =await _userManager.GetRolesAsync(user);
            var roleClaims = roles.Select(x => new Claim(ClaimTypes.Role, x)).ToList();
            var userClaims =await _userManager.GetClaimsAsync(user);

            var claims=new List<Claim>()
            {
                new Claim(JwtRegisteredClaimNames.Sub, user.Email),
                new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Email,user.Email),
            }.Union(userClaims).Union(roleClaims);

            var token = new JwtSecurityToken(
            
                issuer:_configuration["JwtSettings:Issuer"],
                audience: _configuration["JwtSettings:Audience"],
                claims: claims,
                expires: DateTime.Now.AddMinutes(Convert.ToInt32(_configuration["JwtSettings:ExpireInMinutes"])),
                signingCredentials:credentials
            );

            return new JwtSecurityTokenHandler().WriteToken( token);
        }

        public async Task<PasswordGenerateResponse> GeneratePassword(PasswordGenerateRequest passwordGenerateRequest)
        {
            if(passwordGenerateRequest == null)
            {
                throw new ArgumentNullException($"{nameof(passwordGenerateRequest)} is null in Generate password request");
            }
            var oneTimePassword = await _otpRepository.GetAsync(passwordGenerateRequest.TempUserId);
            if(oneTimePassword == null)
            {
                throw new Exception("Please Generate Otp");
            }
            //Checking Wheather password is generating within 10 minutes or not
            DateTime? start = oneTimePassword.CreatedAt;
            DateTime? end = start.Value.AddMinutes(10);
            bool isWithinTime = DateTime.Now >= start && DateTime.Now <= end;
            if (!isWithinTime)
            {
                throw new Exception("Please Generate OTP again");
            }

            if (oneTimePassword.OTP == passwordGenerateRequest.Otp && oneTimePassword.ResetToken==passwordGenerateRequest.ResetToken)
            {
                var user = await _userManager.FindByIdAsync(oneTimePassword.ApplicationUserId.ToString());
                var result = await _userManager.ResetPasswordAsync(user, passwordGenerateRequest.ResetToken, passwordGenerateRequest.Password);
                if (result.Succeeded)
                {
                     await  _otpRepository.DeleteAsync(passwordGenerateRequest.TempUserId);
                    return new PasswordGenerateResponse() { Status = true, Message = "Password changed successfully" };
                }
            }

            throw new Exception("Something Went Wrong While Generating Password");
        }

        public async Task<bool> DeleteUser(string mail)
        {
            var user= await _userManager.FindByEmailAsync(mail);
            var roleResult = await _userManager.RemoveFromRoleAsync(user, user.Subscription);
            var result=  await _userManager.DeleteAsync(user);          
            if (result.Succeeded && roleResult.Succeeded)
            {
                return true;
            }
            return false;
        }

        public async Task<PasswordGenerateResponse> ForgotPasswordAsync(string mail)
        {
            var user = await _userManager.FindByEmailAsync(mail);
            if (user == null)
            {
                throw new Exception("User does not exists ");
            }
            int otp = await MailHelper.SendMail(user.Email, null, null);
            var resetToken = await _userManager.GeneratePasswordResetTokenAsync(user);
            OneTimePassword oneTimePassword = new OneTimePassword()
            {
                ApplicationUserId = user.Id,
                OTP = otp,
                CreatedAt = DateTime.Now,
                TempUserId = Guid.NewGuid(),
                ResetToken = resetToken
            };
            oneTimePassword = await _otpRepository.AddOrUpdateAsync(oneTimePassword);
            PasswordGenerateResponse pgr =new PasswordGenerateResponse()
            {
                ResetToken = resetToken,TempUserId= oneTimePassword.TempUserId
            };
            return pgr;
        }

        public async Task<IList<string>> GetUserRolesFromToken(string token)
        {
            if(token == null)
            {
                throw new Error("Please provide valid token");
            }
           
            string Authorization = token.Replace("Bearer ", "");
            var jwtSecurityHandler=new JwtSecurityTokenHandler();
            var jwt = jwtSecurityHandler.ReadJwtToken(Authorization);
            var email= jwt.Payload["sub"].ToString();           
            if(email == null)
            {
                throw new Exception("Token not Valid");
            }
            var user=await _userManager.FindByEmailAsync(email);
            return await _userManager.GetRolesAsync(user);
        }

        public async Task<string> SignUp(SignUpRequest request)
        {
            return "Signup Successful ";

        }
    }
}
