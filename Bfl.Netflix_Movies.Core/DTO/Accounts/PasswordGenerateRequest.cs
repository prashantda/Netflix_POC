using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bfl.Netflix_Service1.Core.DTO.Accounts
{
    public class PasswordGenerateRequest
    {
        [Required(ErrorMessage = "Something Went Wrong")]
        public Guid TempUserId { get; set; }
        [Required(ErrorMessage = "Otp is required")]
        [Range(100000, 999999, ErrorMessage = "Otp should be 6 digit only")]
        public int Otp { get; set; }
        public string ResetToken { get; set; }

        [RegularExpression("^[a-z]{0,15}$")]
        //[RegularExpression("^(?=.*[A-Z])(?=.*[a-z])(?=.*[!@#$%^&*(),.?":{}|<>])(?=.*\d)[A-Za-z\d!@#$%^&*(),.?":{}|<>]{1,15}$")]            //up to 15 characters 1 uppercase,1lowercase,1 special characters,1 digit needed regular expression
        public string Password { get; set; }
        [Compare(nameof(Password))]
        public string ConfirmPassword { get; set; }
    }
}
