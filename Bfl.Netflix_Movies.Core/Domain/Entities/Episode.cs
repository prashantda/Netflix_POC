using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bfl.Netflix.Core.Domain.Entities
{
    public class Episode : BaseEntity
    {
        [Key]
        public Guid EpisodeId { get; set; }
        [StringLength(30)]
        public string EpisodeName { get; set; }
        public Guid TvShowId { get; set; }
        [ForeignKey("TvShowId")]
        public virtual TvShow TvShows { get; set; }
        
    }
}
