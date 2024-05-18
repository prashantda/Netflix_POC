using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bfl.Netflix.Core.Domain.Entities.Relationships
{
    [Table("MovieCats")]
    public class MovieCast
    {
        [Key]
        public Guid Id { get; set; }
        // [Key,Column(Order =0)]             Instead of using id as key you can use composite key by uncommenting lines
        public Guid MovieId { get; set; }
        [ForeignKey("MovieId")]
        public Movie Movie { get; set; }
        //  [Key, Column(Order = 1)]
        public Guid CastId { get; set; }
        [ForeignKey("CastId")]
        public Cast Casts { get; set; }
    }
}
