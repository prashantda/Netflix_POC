using Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Action = Configurations.Action;

namespace Bfl.Netflix_Tv.Core.DTO.TvShowCast
{
    public class TvShowCastRequest 
    {
        public Guid TvShowId { get; set; }
        public Guid[] Casts { get; set; }
        
    }
}
