using Bfl.Netflix.Core.Domain.Entities;
using Bfl.Netflix.Core.Domain.RepositoryContracts;
using Bfl.Netflix_Service1.Core.DTO.Category;
using Bfl.Netflix_Service1.Core.ServiceContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bfl.Netflix_Service1.Core.Services
{
    public class CategoriesService : ICategoriesService
    {
        public readonly ICategoriesRepository _categoriesRepository;
        public CategoriesService(ICategoriesRepository categoriesRepository)
        {
            _categoriesRepository = categoriesRepository;
        }



        public async Task<CategoryResponse> AddAsync(string category)
        {
            var entity = new Category() { CategoryId = Guid.NewGuid(), CategoryName = category };
            await _categoriesRepository.AddAsync(entity);
            return new CategoryResponse() { CategoryName = entity.CategoryName, CategoryId = entity.CategoryId };
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            var entity = await _categoriesRepository.GetAsync(id);
            if (entity == null)
            {
                throw new ArgumentException("Id not valid");
            }
            await _categoriesRepository.DeleteAsync(id);
            return true;
        }

        public async Task<IEnumerable<string>> GetAll()
        {
            var list = await _categoriesRepository.GetAllAsync();
            var categories = new List<string>();
            categories = list.Select(t => t.CategoryName).ToList();
            return categories;
        }

        public async Task<string> GetByIdAsync(Guid id)
        {
            var entity = await _categoriesRepository.GetAsync(id);
            if (entity == null)
            {
                throw new ArgumentException("Category does not exist with given id");
            }
            return entity.CategoryName;
        }

        public async Task<CategoryResponse> UpdateAsync(Guid id, string category)
        {
            var entity = await _categoriesRepository.GetAsync(id);
            if (entity == null)
            {
                throw new ArgumentException("Category does not exist with given id");
            }
            entity.CategoryName = category;
            await _categoriesRepository.UpdateAsync(entity);
            return new CategoryResponse() { CategoryName = entity.CategoryName, CategoryId = entity.CategoryId };
        }
    }
}
