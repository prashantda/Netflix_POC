using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bfl.Netflix_Tv.Core.DTO.TvShow
{
    public class TvShowUpdateRequest
    {
        public Guid TvShowId { get; set; }
        [StringLength(50)]
        [Required(ErrorMessage = "TvShowName cant not be Empty")]
        public string TvShowName { get; set; }
        [Required(ErrorMessage = "Seasons cant not be Empty")]
        public int Seasons { get; set; }
        [StringLength(400)]
        [Required(ErrorMessage = "Description cant not be Empty")]
        public string Description { get; set; }
        [StringLength(40)]
        [Required(ErrorMessage = "CreatorName cant not be Empty")]
        public string CreatorName { get; set; }
        [StringLength(15)]
        [Required(ErrorMessage = "Language cant not be Empty")]
        public string Language { get; set; }

        public double? Rating { get; set; }
        [Required(ErrorMessage = "ReleaseDate cant not be Empty")]
        public DateTime ReleaseDate { get; set; }
        [Required(ErrorMessage = "Duration cant not be Empty")]
        public int Duration { get; set; }

        public virtual Guid[]? Categories { get; set; }
        public virtual Guid[]? Casts { get; set; }



    }
}