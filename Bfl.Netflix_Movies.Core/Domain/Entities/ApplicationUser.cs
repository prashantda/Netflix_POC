using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bfl.Netflix.Core.Domain.Entities
{
    [Table("Users")]
    public class ApplicationUser: IdentityUser<Guid>
    {
        [StringLength(63)]
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        [StringLength(127)]
        public string Address { get; set; }
        [StringLength(15)]
        public string Gender { get; set; }
        [StringLength(15)]
        public string Subscription { get; set; }
    }
}
