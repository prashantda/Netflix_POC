using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bfl.Netflix_Service1.Core.DTO.Movies
{
    public class MoviesResponse
    {
        public Guid MovieId { get; set; }
       
        public string MovieName { get; set; }
       
        public int ChapterNo { get; set; }
        
        public string Description { get; set; }
       
        public string CreatorName { get; set; }
        
        public string Language { get; set; }
        [StringLength(150)]

        public double? Rating { get; set; }
        
        public DateTime ReleaseDate { get; set; }
        
        public int Duration { get; set; }

        public virtual string[]? Categories { get; set; }

        public virtual string[]? Casts { get; set; }




    }
}