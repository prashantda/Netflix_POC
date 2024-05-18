using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bfl.Netflix_Movies.Core.DTO.FrontEnd
{
    public class SelectPlanRequest
    {
        public string Token { get; set; }
        public string SelectedPlan { get; set; }

    }
}
