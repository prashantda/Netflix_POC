
using Bfl.Netflix.Core.Configurations;
using Bfl.Netflix.Core.ServiceContracts;
using Bfl.Netflix.Helpers;
using Bfl.Netflix_Service1.Core.DTO.Movies;
using Bfl.Netflix_Service1.Core.DTO.Shared;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Bfl.Netflix.Controllers
{
    [Route("api/movie/[controller]")]
    [ApiController]
   // [AllowAnonymous]
    public class MoviesController : ControllerBase
    {
        private readonly IMoviesService _moviesService;
        private readonly IHostEnvironment _host;
        private readonly ILogger<MoviesController> _logger;

        public MoviesController(IMoviesService movies,IHostEnvironment host, ILogger<MoviesController> logger)
        {
            _moviesService = movies;
            _host = host;
            _logger = logger;
        }









        [HttpGet("[action]")]
        [Authorize(Roles= "Customer,Basic,Gold,Platinum,Admin")]
        public async Task<ActionResult<Response<AllMovies>>> GetAllMovies()
        {
            var path = _host.ContentRootPath;
            var result= await _moviesService.GetAllMovies(path);//Movie Images and movieId
            return this.ResponseResult<AllMovies>(200, result, "Successfully Retrieved");
        }




        [HttpGet("[action]")]
        [Authorize(Roles = "Customer,Basic,Gold,Platinum,Admin")]
        public async Task<ActionResult<Response<IEnumerable<MoviesResponse>>>> GetAll()
        {
            var response= await _moviesService.GetAll();//Only list
            return this.ResponseResult<IEnumerable<MoviesResponse>>(200,response,"List Retrieved");
        }

        [HttpPost]
        [Route("[action]")]
        [Authorize(Roles = "Admin")]      
        public async Task<ActionResult<Response<MoviesResponse>>> Add(MoviesAddRequest addMovie)
        {
            var response=await _moviesService.AddMovie(addMovie);
            return this.ResponseResult<MoviesResponse>(200, response, "Movie Added");

        }

        [HttpGet]
        [Route("[action]/{id}")]
        [Authorize(Roles =  "Basic,Gold,Platinum,Admin")]     
        public async Task<ActionResult<Response<MoviesResponse>>> GetMovie(Guid? id)
        {
            _logger.LogInformation("Get movie request at controller start");
            var response=await _moviesService.GetMovieAsync(id);
            _logger.LogInformation("Get movie request at controller end");

            return this.ResponseResult<MoviesResponse>(200, response, "Movie Added");

        }
        [HttpPost("[action]/{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult<Response<MoviesResponse>>> Upload(Guid? id,IFormFile? image , IFormFile? trailer, IFormFile? video)
        {
            if (id is null )
                return null;
            string? imagepath = null, trailerpath = null, videopath=null;
            if (image != null)
             imagepath =  VideoHelper.UploadVideo(id.Value, image, _host,"image").Result;
            if (trailer != null)
                trailerpath = VideoHelper.UploadVideo(id.Value, trailer, _host,"trailer").Result;
            if (video != null)
                videopath = VideoHelper.UploadVideo(id.Value, video, _host,"video").Result;
            var response=await _moviesService.UploadVideos(id.Value, imagepath, trailerpath, videopath);
            return this.ResponseResult<MoviesResponse>(200, response, "File Uploaded");

        }

        [HttpPut("[action]/{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult<Response<MoviesResponse>>> UpdateMovie(Guid id, MovieUpdateRequest moviesAddRequest)     
        {           
           var response=await _moviesService.UpdateMovie(id, moviesAddRequest);
            return this.ResponseResult<MoviesResponse>(200, response, "File Uploaded");
        }

        [HttpDelete("[action]/{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult<Response<MoviesResponse>>> DeleteMovie(Guid? id)
        {
            if(id is  null)
            {
                throw new Error("MovieId is null");
            }
            await  VideoHelper.DeleteVideo(id.Value, "image");
            await VideoHelper.DeleteVideo(id.Value, "trailer");
            await VideoHelper.DeleteVideo(id.Value, "video");
            var response= await  _moviesService.DeleteMovie(id.Value);
            return this.ResponseResult<MoviesResponse>(200, response, "Movie Deleted");

        }


        [HttpGet("[action]/{id}")]
        [Authorize(Roles = "Basic,Gold,Platinum,Admin")]
        public async Task<ActionResult> WatchMovie(Guid id)
        {
            var videoPath=await _moviesService.GetMovieVideoPath(id);
            var stream = await VideoHelper.GetBlob(videoPath);
            return File(stream, "video/mp4");
        }
        [HttpGet("[action]/{id}")]
        [Authorize(Roles = "Basic,Gold,Platinum,Admin")]
        public async Task<ActionResult> WatchTrailer(Guid id)
        {
            var trailerPath =await _moviesService.GetTrailerPath(id);
            var stream =await VideoHelper.GetBlob(trailerPath);
            return File(stream, "video/mp4");
        }
    }
    
}
