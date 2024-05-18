using Bfl.Netflix.Core.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bfl.Netflix_Service1.Core.DTO.Accounts
{
    public class RegisterRequest
    {
        [StringLength(23, ErrorMessage = "Username can't be more than 23 characters")]
        [Required(ErrorMessage = "Username can't be blank")]
        public string UserName { get; set; }
        /*[Required(Message = "Password is required")]
        [StringLength(15, Message = "Password can't be more than 15 characters")]  
        public string Password { get; set; }*/
        [Required(ErrorMessage = "Email is required")]
        [StringLength(63, ErrorMessage = "Email can't be more than 63 characters")]
        [EmailAddress(ErrorMessage = "Email should be in valid format")]
        public string Email { get; set; }
        [Required(ErrorMessage = "PhoneNumber is required")]
        [Phone(ErrorMessage = "PhoneNumber should be in valid format")]
        [StringLength(15, ErrorMessage = "PhoneNumber can't be more than 15 characters")]
        public string PhoneNumber { get; set; }
        [StringLength(63, ErrorMessage = "Name can't be more than 63 characters")]
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "DateOfBirth is required")]

        public DateTime DateOfBirth { get; set; }
        [StringLength(127, ErrorMessage = "Address can't be more than 127 characters")]
        [Required(ErrorMessage = "Address is required")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Gender is required")]
        public Gender Gender { get; set; }

        public bool TwoFactorEnabled { get; set; }
    }
}
