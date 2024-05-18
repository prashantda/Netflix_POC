using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bfl.Netflix.Core.Domain.Entities
{
    [Table("OTP")]
    public class OneTimePassword
    {
        [Key]
        public Guid TempUserId { get; set; }
        [Range(100000,999999)]
        public int OTP { get; set; }
        public Guid ApplicationUserId { get; set; }
        public string ResetToken { get; set; }
        public DateTime CreatedAt { get; set; }
        [ForeignKey("ApplicationUserId")]
        public ApplicationUser User { get; set; }
    }
}
