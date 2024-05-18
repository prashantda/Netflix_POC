using Bfl.Netflix_Movies.Core.DTO.Shared;
using Bfl.Netflix_Movies.Core.DTO.TvShowCategory;
using Bfl.Netflix_Movies.Core.ServiceContracts;
using Bfl.Netflix_Service1.Core.DTO.Shared;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bfl.Netflix_Movies.Controllers
{
    [Route("api/movie/[controller]")]
    [ApiController]
    public class TvShowCategoryController : ControllerBase
    {
        private readonly ITvShowCategoriesService _tvShowCategoriesService;
        private readonly ILogger<TvShowCategoryController> _logger;

        public TvShowCategoryController(ITvShowCategoriesService tvShowCategoriesService,ILogger<TvShowCategoryController> logger)
        {
            _tvShowCategoriesService = tvShowCategoriesService;
            _logger = logger;
        }
        [HttpPost("[action]")]
        [Authorize(Roles ="Admin")]
        public async Task<Response<TvShowCategoryResponse>> Add(TvShowCategoryRequest request)
        {
            _logger.LogInformation("Incoming AddTvShowCAst () of TvShowCastController");
            var response = await _tvShowCategoriesService.AddAsync(request);
            return this.ResponseResult<TvShowCategoryResponse>(200, response, "Succesfully added");
        }

        [HttpDelete("[action]")]
        [Authorize(Roles = "Admin")]
        public async Task<Response<TvShowCategoryResponse>> Delete(GenericRequest tvShowId)
        {
            _logger.LogInformation("Incoming Delete () of TvShowCategoryController");
            var response = await _tvShowCategoriesService.DeleteAsync(tvShowId.Id);
            return this.ResponseResult<TvShowCategoryResponse>(200, response, "Succesfully Deleted");
        }

        [HttpGet("[action]")]
        [Authorize(Roles = "Customer,Basic,Gold,Platinum,Admin")]
        public async Task<Response<TvShowCategoryResponse>> Get(GenericRequest tvShowId)
        {
            _logger.LogInformation("Incoming Get () of TvShowCategoryController");
            TvShowCategoryResponse response = await _tvShowCategoriesService.GetAsync(tvShowId.Id);
            return this.ResponseResult<TvShowCategoryResponse>(200, response, "Succesfully Fetched");
        }
    }
}
