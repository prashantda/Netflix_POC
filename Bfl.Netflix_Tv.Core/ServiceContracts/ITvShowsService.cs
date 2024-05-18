using Bfl.Netflix_Tv.Core.DTO.TvShow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bfl.Netflix_Tv.Core.ServiceContracts
{
    public interface ITvShowsService
    {
        Task<TvShowResponse> AddAsync(TvShowAddRequest tv, string token);
        Task<TvShowResponse> UpdateAsync(TvShowUpdateRequest tv, string token);
        Task<TvShowResponse> DeleteAsync(Guid id,string token);
        Task<TvShowResponse> GetAsync(Guid id, string token);
        Task<IEnumerable<TvShowResponse>> GetAllAsync(string token);

    }
}
