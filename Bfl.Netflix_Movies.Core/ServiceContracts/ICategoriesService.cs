using Bfl.Netflix_Service1.Core.DTO.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bfl.Netflix_Service1.Core.ServiceContracts
{
    public interface ICategoriesService
    {
        Task<IEnumerable<string>> GetAll();
        Task<string> GetByIdAsync(Guid id);
        Task<CategoryResponse> AddAsync(string category);
        Task<CategoryResponse> UpdateAsync(Guid id, string category);
        Task<bool> DeleteAsync(Guid id);
    }
}
