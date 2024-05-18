using Bfl.Netflix.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bfl.Netflix.Core.Domain.RepositoryContracts
{
    public interface ICastsRepository :IGenericRepository<Cast>
    {
        Task<Cast> GetCastByNameAsync(string name);
        Task DeleteAll();

        Task<int> CountAsync();
    }
}
