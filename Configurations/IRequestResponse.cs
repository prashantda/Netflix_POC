using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Configurations
{
    public interface IRequestResponse
    {
        public Guid TvShowId { get; set; }

        public Guid[] CastsId { get; set; }
        public List<string> Casts { get; set; }
        public Guid[] CategoriesId { get; set; }
        public List<string> Categories { get; set; }

        public Action Action { get; set; }
    }
}
