using Bfl.Netflix_Movies.Core.DTO.TvShowCast;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bfl.Netflix_Movies.Core.ServiceContracts
{
    public interface ITvShowsCastService
    {
        Task<TvShowCastResponse> AddAsync(TvShowCastRequest request);
        Task<TvShowCastResponse> DeleteAsync(Guid tvShowId);
        Task<TvShowCastResponse> GetAsync(Guid tvShowId);
    }
}
