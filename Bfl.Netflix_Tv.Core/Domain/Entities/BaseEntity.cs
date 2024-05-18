using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bfl.Netflix_Tv.Core.Domain.Entities
{
    public class BaseEntity
    {
        [StringLength(400)]
        public string Description { get; set; }
        [StringLength(40)]
        public string CreatorName { get; set; }
        [StringLength(15)]
        public string Language { get; set; }
        [StringLength(150)]
        public string ImagePath { get; set; }
        public double? Rating { get; set; }
        [StringLength(150)]
        public string TrailerPath { get; set; }
        [StringLength(150)]
        public string VideoPath { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int Duration { get; set; }

        public string Access { get; set; }  



    }
}
