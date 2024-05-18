using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bfl.Netflix_Tv.Core.DTO.TvShowCategory
{
    public class TvShowCategoryResponse
    {
        public Guid TvShowId { get; set; }
        public List<string> Categories { get; set; }
    }
}
