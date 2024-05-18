using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bfl.Netflix.Core.Domain.Entities.Relationships
{
    [Table("MovieCategories")]
    public class MovieCategory
    {
        [Key]
       public Guid Id { get; set; }

        public Guid MovieId { get; set; }
        [ForeignKey("MovieId")]
        public Movie Movie { get; set; }      
        public Guid CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public Category Category { get; set; }



    }
}
