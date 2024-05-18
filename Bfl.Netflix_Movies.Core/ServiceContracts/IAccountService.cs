using Bfl.Netflix.Core.Domain.Entities;
using Bfl.Netflix_Movies.Core.DTO.Accounts;
using Bfl.Netflix_Service1.Core.DTO.Accounts;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bfl.Netflix.Core.ServiceContracts
{
    public interface IAccountService
    {
        Task<RegisterResponse> RegisterUser(RegisterRequest registerRequest);
        Task<SignInResponse> SignIn(SignInRequest signInRequest);
        Task<bool> UpdateSubscription(SubscriptionRequest subscriptionRequest);
        Task<PasswordGenerateResponse> GeneratePassword(PasswordGenerateRequest passwordGenerateRequest);
        Task<bool> DeleteUser(string mail);
        Task<PasswordGenerateResponse> ForgotPasswordAsync(string mail);
        Task<IList<string>> GetUserRolesFromToken(string token);
        Task<string> SignUp(SignUpRequest request);
    }
}
