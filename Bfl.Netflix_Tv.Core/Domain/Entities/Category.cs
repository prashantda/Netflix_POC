
using System.ComponentModel.DataAnnotations;

namespace Bfl.Netflix_Tv.Core.Domain.Entities
{
    public class Category
    {
        [Key]
        public Guid CategoryId { get; set; }
        [StringLength(25)]
        public string CategoryName { get; set; }

    }
}