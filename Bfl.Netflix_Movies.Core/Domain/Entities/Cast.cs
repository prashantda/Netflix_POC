using Bfl.Netflix.Core.Domain.Entities.Relationships;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bfl.Netflix.Core.Domain.Entities
{
    public class Cast
    {
        [Key]
        public Guid CastId { get; set; }
        [StringLength(40)]
        public string CastName { get; set; }

        public virtual ICollection<TvShowCast>? TvShowCasts { get; set; }
        public virtual ICollection<MovieCast>? MovieCasts { get; set; }

    }
}
