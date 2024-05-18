using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bfl.Netflix_Tv.Core.DTO.TvShow
{
    public class TvShowResponse
    {
        public Guid TvShowId { get; set; }
        public string TvShowName { get; set; }
        
        public int Seasons { get; set; }
       
        public string Description { get; set; }
        
        public string CreatorName { get; set; }
       
        public string Language { get; set; }
       
        public string Access { get; set; }
        public double? Rating { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int Duration { get; set; }
        public virtual string[]? Categories { get; set; }

        public virtual string[]? Casts { get; set; }

       
    }
}
