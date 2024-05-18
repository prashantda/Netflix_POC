using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bfl.Netflix_Service1.Core.DTO.Accounts
{
    public class SignInRequest
    {
        [Required(ErrorMessage = "Email is required")]
        [StringLength(63, ErrorMessage = "Email can not have more than 63 characters")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Password is required")]
        [StringLength(15, ErrorMessage = "Password can't be more than 15 characters")]
        public string Password { get; set; }

    }
}
