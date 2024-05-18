using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bfl.Netflix_Service1.Core.DTO.Movies
{
    public class AllMovies
    {
        public List<string> Genre { get; set; }
        public List<MultipleFiles>[] Movie { get; set; }
        public AllMovies(int count)
        {
            Genre=new List<string>();
            Movie = new List<MultipleFiles>[count];
        }
        public AllMovies()
        {            
        }
    }
}
