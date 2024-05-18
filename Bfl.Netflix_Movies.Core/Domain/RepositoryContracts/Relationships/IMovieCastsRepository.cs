using Bfl.Netflix.Core.Domain.Entities;
using Bfl.Netflix.Core.Domain.Entities.Relationships;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bfl.Netflix.Core.Domain.RepositoryContracts
{
    public interface IMovieCastsRepository : IGenericRepository<MovieCast>
    {
        Task DeleteAll(Guid movieId);
        
    }
}
