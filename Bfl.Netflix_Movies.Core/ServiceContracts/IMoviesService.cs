using Bfl.Netflix_Service1.Core.DTO.Movies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bfl.Netflix.Core.ServiceContracts
{
    public interface IMoviesService
    {
        Task<MoviesResponse> AddMovie(MoviesAddRequest movie);
        Task<MoviesResponse> GetMovieAsync(Guid? id);
        Task<MoviesResponse> UploadVideos(Guid id,string Image, string trailer, string video);
        Task<MoviesResponse> UpdateMovie(Guid id, MovieUpdateRequest moviesAddRequest);
        Task<MoviesResponse> DeleteMovie(Guid id);
        Task<IEnumerable<MoviesResponse>> GetAll();
        Task<string> GetMovieVideoPath(Guid id);
        Task<string> GetTrailerPath(Guid id);
        Task<AllMovies> GetAllMovies(string path);
    }
}
