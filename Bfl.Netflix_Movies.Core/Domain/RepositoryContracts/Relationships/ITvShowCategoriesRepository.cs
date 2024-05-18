using Bfl.Netflix.Core.Domain.Entities;
using Bfl.Netflix.Core.Domain.Entities.Relationships;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bfl.Netflix.Core.Domain.RepositoryContracts
{
    public interface ITvShowCategoriesRepository : IGenericRepository<TvShowCategory>
    {
        Task<IEnumerable<TvShowCategory>> GetAllCategoriesById(Guid tvShowId);
        Task<IEnumerable<TvShowCategory>> DeleteAll(Guid tvShowId);
    }
}
