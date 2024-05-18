using Bfl.Netflix.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bfl.Netflix.Core.Domain.RepositoryContracts
{
    public interface ICategoriesRepository : IGenericRepository<Category>
    {
        Task<Category> GetByNameAsync(string name);
        Task<int> CountAsync();
    }
}
