using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bfl.Netflix_Tv.Core.DTO.Shared
{
    public class GenericRequest
    {
        public Guid Id { get; set; }
        public GenericRequest(Guid id)
        {
            Id=id;
        }
    }
}
