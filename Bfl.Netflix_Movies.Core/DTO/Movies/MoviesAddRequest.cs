using Bfl.Netflix.Core.Domain.Entities;
using Bfl.Netflix.Core.Domain.Entities.Relationships;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bfl.Netflix_Service1.Core.DTO.Movies
{
    public class MoviesAddRequest
    {
        [StringLength(50)]
        [Required(ErrorMessage = "MovieName cant not be Empty")]
        public string MovieName { get; set; }
        [Required(ErrorMessage = "ChapterNo/Part cant not be Empty")]
        public int ChapterNo { get; set; }
        [StringLength(400)]
        [Required(ErrorMessage = "Description cant not be Empty")]
        public string Description { get; set; }
        [StringLength(40)]
        [Required(ErrorMessage = "CreatorName cant not be Empty")]
        public string CreatorName { get; set; }
        [StringLength(15)]
        [Required(ErrorMessage = "Language cant not be Empty")]
        public string Language { get; set; }
        [StringLength(20)]
        [Required(ErrorMessage = "Access cant not be Empty")]
        public string Access { get; set; }
        public double? Rating { get; set; }
        [Required(ErrorMessage = "ReleaseDate cant not be Empty")]
        public DateTime ReleaseDate { get; set; }
        [Required(ErrorMessage = "Duration cant not be Empty")]
        public int Duration { get; set; }
        [Required(ErrorMessage = "Categories cant not be Empty")]
        public virtual Guid[]? Categories { get; set; }
        [Required(ErrorMessage = "Casts cant not be Empty")]
        public virtual Guid[]? Casts { get; set; }
    }
}
