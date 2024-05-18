using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bfl.Netflix_Movies.Core.DTO.Accounts
{
    public class SignUpRequest
    {
        [Required(ErrorMessage ="Email is Required")]
        [EmailAddress(ErrorMessage ="Email should be in valid format")]
        [MaxLength(63,ErrorMessage ="Only 63 characters are allowed")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Password is Required")]
        [MaxLength(15, ErrorMessage = "Only 15 characters are allowed")]
        public string Password { get; set; }
    }
}
