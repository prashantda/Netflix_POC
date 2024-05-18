using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bfl.Netflix.Core.Domain.Entities.Relationships
{
    [Table("TvShowCategories")]
    public class TvShowCategory
    {
        [Key]
        public Guid Id { get; set; }
       // [Key,Column(Order =0)]             Instead of using id as key you can use composite key by uncommenting lines
        public Guid TvShowId { get; set; }
        [ForeignKey("TvShowId")]
        public TvShow TvShow { get; set; }
      //  [Key, Column(Order = 1)]
        public Guid CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public Category Category { get; set; }


    }
}
