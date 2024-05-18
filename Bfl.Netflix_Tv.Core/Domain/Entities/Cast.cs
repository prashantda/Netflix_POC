
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bfl.Netflix_Tv.Core.Domain.Entities
{
    public class Cast
    {
        [Key]
        public Guid CastId { get; set; }
        [StringLength(40)]
        public string CastName { get; set; }

       

    }
}
