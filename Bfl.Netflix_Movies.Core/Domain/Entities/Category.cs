using Bfl.Netflix.Core.Domain.Entities.Relationships;
using System.ComponentModel.DataAnnotations;

namespace Bfl.Netflix.Core.Domain.Entities
{
    public class Category
    {
        [Key]
        public Guid CategoryId { get; set; }
        [StringLength(25)]
        public string CategoryName { get; set; }

        public virtual ICollection<MovieCategory>? MovieCategories { get; set; }
        public virtual ICollection<TvShowCategory>? TvShowCategories { get; set; }
    }
}