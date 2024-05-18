using Bfl.Netflix.Core.Domain.Entities;
using Bfl.Netflix.Core.Domain.Entities.Relationships;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bfl.Netflix.Core.Domain.RepositoryContracts
{
    public interface IMovieCategoriesRepository :IGenericRepository<MovieCategory>
    {
        Task DeleteAll(Guid movieId);
    }
}
