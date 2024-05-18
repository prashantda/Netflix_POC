using AutoMapper;
using Bfl.Netflix_Tv.Core.DTO.Shared;
using Bfl.Netflix_Tv.Core.DTO.TvShow;
using Bfl.Netflix_Tv.Core.ServiceContracts;
using Bfl.Netflix_Tv.Core.SyncDataServices.GRPC;
using Bfl.Netflix_Tv.Filters.AuthorizationFilters;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bfl.Netflix_Tv.Controllers
{
    [Route("api/tv/[controller]")]
    [ApiController]
    public class TvShowsController : ControllerBase
    {
        private readonly ITvShowsService _tvShowsService;
        private readonly ILogger<TvShowsController> _logger;
        private readonly IGrpcTvDataClientServices _grpcTvDataClient;

        public TvShowsController(ITvShowsService tvShowsService,ILogger<TvShowsController> logger, IGrpcTvDataClientServices grpcTvDataClient)
        {
            _tvShowsService = tvShowsService;
            _logger = logger;
            _grpcTvDataClient = grpcTvDataClient;
        }
        [HttpGet("[action]")]
        public async Task<ActionResult<Response<string>>> Docker()
        {
            return this.ResponseResult<String>(200, "Its Working", "Success");
        }
        [HttpGet("[action]")]
        public async Task<ActionResult<Response<IEnumerable<CastOrCategoryDTO>>>> GetCastsOrCategories(string castOrCategory)
        {
            var response =await _grpcTvDataClient.GetAllCastsOrCategories(castOrCategory, HttpContext.Request.Headers["Authorization"]);
            return this.ResponseResult<IEnumerable<CastOrCategoryDTO>>(200, response.ToList(), "Success");
        }

        [HttpPost]
        public async Task<ActionResult<Response<TvShowResponse>>> Upload(Guid? id, IFormFile? image, IFormFile? trailer)
        {
            throw new NotImplementedException();
        }

        [HttpPost("[action]")]
        public async Task<ActionResult<Response<TvShowResponse>>> Add(TvShowAddRequest tvShowAddRequest)
        {
            _logger.LogInformation("Incoming into Add endpoint of tvshow");
           var response=await _tvShowsService.AddAsync(tvShowAddRequest, HttpContext.Request.Headers["Authorization"]);
            return this.ResponseResult<TvShowResponse>(200, response, "Successfully added");
        }
        [HttpGet("[action]")] 
        public async Task<ActionResult<Response<TvShowResponse>>> Get(Guid tvShowId)
        {
            _logger.LogInformation("Incoming into Get endpoint of tvshow");
            var response = await _tvShowsService.GetAsync(tvShowId, HttpContext.Request.Headers["Authorization"]);
            return this.ResponseResult<TvShowResponse>(200, response, "Successfully Fetched");
        }
        [HttpDelete("[action]")]
        [Authorize("Customer","Basic","Gold","Platinum","Admin")]
        public async Task<ActionResult<Response<TvShowResponse>>> Delete(Guid tvShowId)
        {
            _logger.LogInformation("Incoming into Get endpoint of tvshow");
            TvShowResponse response = await _tvShowsService.DeleteAsync(tvShowId, HttpContext.Request.Headers["Authorization"]);
            return this.ResponseResult<TvShowResponse>(200, response, "Successfully Deleted");
        }


    }
}
