using Bfl.Netflix_Service1.Core.DTO.Category;
using Bfl.Netflix_Service1.Core.ServiceContracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bfl.Netflix_Service1.Controllers
{
    [Route("api/movie/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoriesService _categoriesService;
        public CategoriesController(ICategoriesService categoriesService)
        {
            _categoriesService = categoriesService;
        }

        [HttpGet("[action]")]
        public async Task<IEnumerable<string>> GetAll()
        {
            return await _categoriesService.GetAll();
        }


        [HttpGet("[action]/{id}")]
        public async Task<string> Get(Guid id)
        {
            return await _categoriesService.GetByIdAsync(id);
        }


        [HttpPost("[action]")]
        public async Task<CategoryResponse> Add(string category)
        {
            return await _categoriesService.AddAsync(category);
        }



        [HttpPut("[action]/{id}")]
        public async Task<CategoryResponse> Update(Guid id,  string category)
        {
            return await _categoriesService.UpdateAsync(id, category);
        }


        [HttpDelete("[action]/{id}")]
        public async Task<bool> Delete(Guid id)
        {
            return await _categoriesService.DeleteAsync(id);
        }
    }
}
