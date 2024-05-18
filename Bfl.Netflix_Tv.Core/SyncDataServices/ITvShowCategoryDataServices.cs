using Bfl.Netflix_Tv.Core.DTO.Shared;
using Bfl.Netflix_Tv.Core.DTO.TvShowCategory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bfl.Netflix_Tv.Core.SyncDataServices
{
    public interface ITvShowCategoryDataServices
    {
        Task<Response<TvShowCategoryResponse>> AddAsync(TvShowCategoryRequest request, string token);
        Task<Response<TvShowCategoryResponse>> DeleteOrGetAsync(Guid id,string token,string method);
        

    }
}
