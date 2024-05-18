
using Bfl.Netflix_Service1.Core.DTO.Casts;
using Bfl.Netflix_Service1.Core.ServiceContracts;
using Microsoft.AspNetCore.Mvc;


namespace Bfl.Netflix_Service1.Controllers
{
    [Route("api/movie/[controller]")]
    [ApiController]
    public class CastsController : ControllerBase
    {
        private readonly ICastsService _castsService;
        public CastsController(ICastsService castsService)
        {
            _castsService = castsService;
        }
        

        [HttpGet("[action]")]
        public async Task<IEnumerable<string>> GetAll()
        {
            return await _castsService.GetAll();
        }

        
        [HttpGet("[action]/{id}")]
        public async Task<string> Get(Guid id)
        {
            return await _castsService.GetByIdAsync(id);
        }

        
        [HttpPost("[action]")]
        public async Task<CastResponse> Add( string cast)
        {
            return await _castsService.AddAsync(cast);
        }
        [HttpPost("[action]")]
        public async Task AddAll(CastResponse[] castResponses)
        {
            await _castsService.AddAll(castResponses);
        }


        [HttpPut("[action]/{id}")]
        public async Task<CastResponse> Update(Guid id,string cast)
        {
           return await _castsService.UpdateAsync(id, cast);
        }

       
        [HttpDelete("[action]/{id}")]
        public async Task<bool>  Delete(Guid id)
        {
            return await _castsService.DeleteAsync(id);
        }
    }
}
