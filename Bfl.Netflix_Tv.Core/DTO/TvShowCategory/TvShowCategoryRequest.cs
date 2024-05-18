using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bfl.Netflix_Tv.Core.DTO.TvShowCategory
{
    public class TvShowCategoryRequest
    {
        public Guid TvShowId { get; set; }
        public Guid[] Categories { get; set; }
    }
}
