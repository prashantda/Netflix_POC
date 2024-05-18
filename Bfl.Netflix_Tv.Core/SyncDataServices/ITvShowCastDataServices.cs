using Bfl.Netflix_Tv.Core.DTO.Shared;
using Bfl.Netflix_Tv.Core.DTO.TvShowCast;
using Bfl.Netflix_Tv.Core.DTO.TvShowCategory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bfl.Netflix_Tv.Core.SyncDataServices
{
    public interface ITvShowCastDataServices
    {
        Task<Response<TvShowCastResponse>> AddAsync(TvShowCastRequest request,string token);
        Task<Response<TvShowCastResponse>> DeleteOrGetAsync(Guid id, string token,string method);
       

    }
}
