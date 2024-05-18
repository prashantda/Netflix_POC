
using Bfl.Netflix_Movies.Core.DTO.TvShowCast;
using Bfl.Netflix_Movies.Core.ServiceContracts;
using Bfl.Netflix_Service1.Core.DTO.Shared;
using Microsoft.AspNetCore.Authorization;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Mvc;
using Bfl.Netflix_Movies.Core.DTO.Shared;

namespace Bfl.Netflix_Movies.Controllers
{
    [Route("api/movie/[controller]")]
    [ApiController]
    
    public class TVShowCastController : ControllerBase
    {
        private readonly ITvShowsCastService _tvShowsService;
        private readonly ILogger<ITvShowsCastService> _logger;

        public TVShowCastController(ITvShowsCastService tvShowsService,ILogger<ITvShowsCastService> logger)
        {
            _tvShowsService = tvShowsService;
            _logger = logger;
        }
        [HttpPost("[action]")]
        [Authorize(Roles ="Admin")]
        public async Task<Response<TvShowCastResponse>> Add(TvShowCastRequest request)
        {
            _logger.LogInformation("Incoming Add () of TvShowCastController");
          var response=await  _tvShowsService.AddAsync(request);
            return this.ResponseResult<TvShowCastResponse>(200,response,"Succesfully added");
        }
        [HttpDelete("[action]")]
        [Authorize(Roles ="Admin")]
        public async Task<Response<TvShowCastResponse>> Delete(GenericRequest tvShowId)
        {
            _logger.LogInformation("Incoming Delete () of TvShowCastController");
            var response = await _tvShowsService.DeleteAsync(tvShowId.Id);
            return this.ResponseResult<TvShowCastResponse>(200, response, "Succesfully Deleted");
        }
        [HttpGet("[action]")]
        [Authorize(Roles = "Customer,Basic,Gold,Platinum,Admin")]
        public async Task<Response<TvShowCastResponse>> Get(GenericRequest tvShowId)
        {
            _logger.LogInformation("Incoming Get () of TvShowCastController");
            TvShowCastResponse response = await _tvShowsService.GetAsync(tvShowId.Id);
            return this.ResponseResult<TvShowCastResponse>(200, response, "Succesfully Fetched");
        }

    }
}
