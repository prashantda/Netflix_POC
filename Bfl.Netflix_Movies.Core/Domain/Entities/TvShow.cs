using Bfl.Netflix.Core.Domain.Entities.Relationships;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bfl.Netflix.Core.Domain.Entities
{
    public  class TvShow : BaseEntity
    {
        [Key]
        public Guid TvShowId { get; set; }
        [StringLength(40)]
        public string TvShowName { get; set; }
        public int Seasons { get; set; }
       public virtual ICollection<Episode>? Episodes { get; set; }
        public virtual ICollection<TvShowCategory>? TvShowCategories { get; set; }
        public virtual ICollection<TvShowCast>? TvShowCasts{ get; set; }


    }
}
