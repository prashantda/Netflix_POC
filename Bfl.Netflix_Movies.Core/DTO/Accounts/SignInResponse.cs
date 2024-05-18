using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bfl.Netflix_Service1.Core.DTO.Accounts
{
    public class SignInResponse
    {

        public string Username { get; set; }
        // public Guid Id { get; set; }
        public string Token { get; set; }
        public string RefreshToken { get; set; }

    }
}
