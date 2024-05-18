using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bfl.Netflix_Service1.Core.DTO.Casts
{
    public class CastResponse
    {

        public Guid castId { get; set; }
        
        public string castName { get; set; }
    }
}
