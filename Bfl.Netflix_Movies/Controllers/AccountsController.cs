using Bfl.Netflix.Core.Domain.Entities;
using Bfl.Netflix.Core.Enums;
using Bfl.Netflix.Core.Helpers;
using Bfl.Netflix.Core.ServiceContracts;
using Bfl.Netflix_Movies.Core.DTO.Accounts;
using Bfl.Netflix_Service1.Core.DTO.Accounts;
using Bfl.Netflix_Service1.Core.DTO.Movies;
using Bfl.Netflix_Service1.Core.DTO.Shared;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;

namespace Bfl.Netflix.Controllers
{
    [Route("api/movie/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class AccountsController : ControllerBase
    {
        private readonly IAccountService _accountService;
        private readonly ILogger<AccountsController> _logger;
        private readonly IConfiguration _configuration;
       

        public AccountsController(IAccountService accountService,ILogger<AccountsController> logger,IConfiguration configuration)
        {
            _accountService = accountService;
            _logger = logger;
            _configuration = configuration;
        }
        
        

        [HttpGet("[action]")]
        public async Task<ActionResult<Response<string>>> Docker()
        {
            return   this.ResponseResult<String>(200, "Its Working", "Success"); 
        }


        [HttpGet("[action]/{mail}")]
        [Authorize(Roles ="Admin")]
        public async Task<ActionResult<Response<String>>> DeleteUser(string mail)
        {
             var result= await _accountService.DeleteUser(mail);
            if (result)
            {
                return this.ResponseResult<String>(200, "True", "Successfully Deleted");
            }
            return this.ResponseResult<String>(200, "False", "Something went wrong");
        }
        [HttpPost("[action]")]
        public async Task<ActionResult<Response<RegisterResponse>>> Register(RegisterRequest registerRequest)
        {
            var response= await _accountService.RegisterUser(registerRequest);
            return this.ResponseResult<RegisterResponse>(200, response, "User Registered");
        }

        [HttpPost("[action]")]
        public async Task<ActionResult<Response<SignInResponse>>> SignIn(SignInRequest signInRequest)
        {
            var response= await _accountService.SignIn(signInRequest);
            return this.ResponseResult<SignInResponse>(200, response, "SignIn Successfull");

        }
        [HttpPost("[action]")]
        public async Task<ActionResult<Response<string>>> UpdateSubscription(SubscriptionRequest subscriptionRequest)
        {
            var result= await _accountService.UpdateSubscription(subscriptionRequest);
            if (result)
            {
                return this.ResponseResult<String>(200, "True", "Successfully Updated");
            }
            return this.ResponseResult<String>(500, "False", "Something went wrong");
        }
        [HttpPost("[action]")]
        public async Task<ActionResult<Response<PasswordGenerateResponse>>> SavePassword(PasswordGenerateRequest passwordGenerateRequest)
        {
            var response= await _accountService.GeneratePassword(passwordGenerateRequest);
            return this.ResponseResult<PasswordGenerateResponse>(200, response, "Password saved successfully");

        }

        [HttpPost("[action]/{mail}")]
        public async Task<ActionResult<Response<PasswordGenerateResponse>>> ForgotOrResendPassword(string mail)
        {       
                var response=await _accountService.ForgotPasswordAsync(mail);
            return this.ResponseResult<PasswordGenerateResponse>(200, response, "Mail sent successfully");
        }
         
        [HttpGet("[action]")]
        [Authorize(Roles ="Customer,Basic,Gold,Platinum,Admin")]
        public async Task<ActionResult<Response<IList<string>>>> GetUserRoles()
        {
           
            var response= await _accountService.GetUserRolesFromToken(HttpContext.Request.Headers["Authorization"]);
           return this.ResponseResult(200, response, "Roles fetched");
        }

    }
}
