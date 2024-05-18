using Bfl.Netflix.Core.Domain.Entities.Relationships;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bfl.Netflix.Core.Domain.Entities
{
    public class Movie : BaseEntity
    {
        [Key]
        public Guid MovieId { get; set; }
        [StringLength(50)]
        public string MovieName { get; set; }
        public int ChapterNo { get; set; }
       
         public virtual ICollection<MovieCategory>? MovieCategories { get; set; }
        public virtual ICollection<MovieCast>? MovieCasts { get; set; }
    }
}
