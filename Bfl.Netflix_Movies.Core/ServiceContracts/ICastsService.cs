using Bfl.Netflix.Core.Domain.Entities;
using Bfl.Netflix_Service1.Core.DTO.Casts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bfl.Netflix_Service1.Core.ServiceContracts
{
    public interface ICastsService
    {
        Task<IEnumerable<string>> GetAll();
        Task<bool> DeleteAsync(Guid id);
        Task<CastResponse> UpdateAsync(Guid id, string cast);
        Task<CastResponse> AddAsync(string cast);
        Task<string> GetByIdAsync(Guid id);
        Task AddAll(IEnumerable<CastResponse> castRequest);
    }
}
