using AutoMapper;
using Bfl.Netflix.Core.Domain.Entities;
using Bfl.Netflix.Core.Domain.Entities.Relationships;
using Bfl.Netflix.Core.Domain.RepositoryContracts;
using Bfl.Netflix.Core.ServiceContracts;
using Bfl.Netflix_Service1.Core.DTO.Movies;
using System.Linq;
using Microsoft.Data.SqlClient;
using Microsoft.AspNetCore.Mvc;
using Bfl.Netflix.Core.Configurations;
using Bfl.Netflix_Service1.Core.DTO.Shared;

namespace Bfl.Netflix.Core.Services
{
    public class MoviesService : IMoviesService
    {
        private readonly IMoviesRepository _moviesRepository;
        private readonly IMapper _mapper;
        private readonly IMovieCastsRepository _movieCastsRepository;
        private readonly IMovieCategoriesRepository _movieCategoriesRepository;
        private readonly ICastsRepository _castsRepository;
        private readonly ICategoriesRepository _categoriesRepository;

        public MoviesService(IMoviesRepository moviesRepository,IMapper mapper,
            IMovieCastsRepository movieCastsRepository, IMovieCategoriesRepository movieCategoriesRepository,
            ICategoriesRepository categoriesRepository,ICastsRepository castsRepository)
        {
            _moviesRepository = moviesRepository;
            _mapper = mapper;
            _movieCastsRepository = movieCastsRepository;
            _movieCategoriesRepository = movieCategoriesRepository;
            _categoriesRepository = categoriesRepository;
            _castsRepository = castsRepository;
        }
        #region ADO.Net
        public async Task<AllMovies> GetAllMovies(string path)
        {

           int categoryCount=await _categoriesRepository.CountAsync();
            AllMovies allMovies = new AllMovies(categoryCount);
            allMovies.Genre = _categoriesRepository.GetAllAsync().Result.Select(t => t.CategoryName).ToList();
           
            for (var i = 0; i < categoryCount; i++)
            {
                List<MultipleFiles> fileResults = new List<MultipleFiles>();
                List<Movie> movies = await GetAllFiles(allMovies.Genre[i]);
                foreach (var movie in movies)
                {                
                    var files = new MultipleFiles() { Id = movie.MovieId, Path = movie.ImagePath };
                    fileResults.Add(files);
                }
                
                allMovies.Movie[i]= fileResults;
            }
            
            return allMovies;
 
        }
        public async Task<List<Movie>> GetAllFiles(string? genre)
        {
            List<Movie> movies = new List<Movie>();
            using (SqlConnection connection = new SqlConnection(Configuration.ConnectionString))
            {
                await connection.OpenAsync();
                // using (SqlCommand command = new SqlCommand("SELECT TOP (10) [MovieId],[ImagePath] FROM [Netflix].[dbo].[Movies] with (nolock)", connection))
                 using (SqlCommand command = new SqlCommand($"SELECT TOP (15) m.MovieId,m.ImagePath FROM " +
                     $"[Netflix].[dbo].[Movies] m INNER JOIN [Netflix].[dbo].[MovieCategories] mc " +
                     $"ON m.MovieId = mc.MovieId  INNER JOIN [Netflix].[dbo].[Categories] c " +
                     $"ON c.CategoryId = mc.CategoryId WHERE c.CategoryName = '{genre}' ORDER BY NEWID()", connection))

                {
                    using (SqlDataReader reader = await command.ExecuteReaderAsync())
                    {

                        while (await reader.ReadAsync())
                        {
                            movies.Add(
                                    new Movie()
                                    {
                                        MovieId = reader.GetGuid(0),
                                        ImagePath = reader.GetString(1)
                                    });
                        }
                    }
                }
            }
            return movies;
        }

        #endregion

        #region Identity Methods
        public async Task<List<MovieCast>> GetMovieCastsFromArray(Guid id,Guid[] casts)
        {
            List<MovieCast> moviecasts = new List<MovieCast>();
            foreach (var cast in casts)
            {
                moviecasts.Add(new MovieCast() { MovieId = id, CastId = cast });
            }
            return moviecasts;
        }
        public async Task<List<MovieCategory>> GetMovieCategoriesFromArray(Guid id, Guid[] categories)
        {
            List<MovieCategory> moviecategories = new List<MovieCategory>();
            foreach (var category in categories)
            {
                moviecategories.Add(new MovieCategory() { MovieId = id, CategoryId = category });
            }
            return moviecategories;
        }
        public async Task<MoviesResponse> AddMovie(MoviesAddRequest movieAddRequest)
        {
            if(movieAddRequest is null)//If incoming is null return null
            {
                return null;
            }
            var movie = _mapper.Map<Movie>(movieAddRequest);//Converting Dto to movie object
            var movieid = Guid.NewGuid();//Generating new id for movie entity to assign
            movie.MovieId = movieid;//Assigned id to movie object
            movie.ImagePath = "_";
            movie.TrailerPath = "_";
            movie.VideoPath = "_";
            if(movieAddRequest.Casts is not null)
            {                 
                movie.MovieCasts=await GetMovieCastsFromArray(movie.MovieId, movieAddRequest.Casts);
            }
            if(movieAddRequest.Categories is not null)
            {              
                movie.MovieCategories =await GetMovieCategoriesFromArray(movie.MovieId, movieAddRequest.Categories);
            }
           await _moviesRepository.AddAsync(movie);
            
            return _mapper.Map<MoviesResponse>(movie);
        }

        public async Task<MoviesResponse> DeleteMovie(Guid id)
        {
            var movieResponse =await GetMovieAsync(id);
            if (movieResponse == null)
            {
                return null;
            }
            else
            {
                await _moviesRepository.DeleteAsync(id);
                return movieResponse;
            }
        }

        public async Task<IEnumerable<MoviesResponse>> GetAll()
        {
            return _moviesRepository.GetAllAsync().Result.Select(t=>_mapper.Map<MoviesResponse>(t)).ToList();
        }

        public async  Task<MoviesResponse> GetMovieAsync(Guid? movieId)
        {
            if(movieId is null || movieId == Guid.Empty)
            {
                return null;
            }

            Movie movie = await _moviesRepository.GetMovieWithCastNCategegoryAsync(movieId.Value);
            if(movie is null)
            {
                throw new Exception("Not Found");
            }
            var movieResponse = _mapper.Map<MoviesResponse>(movie);
            if (movie.MovieCasts is not null)
            {
                List<string> a = new List<string>();
                foreach (var cast in movie.MovieCasts)
                {
                    a.Add(cast.Casts.CastName);  
                }
                movieResponse.Casts = a.ToArray();
            }
            if (movie.MovieCategories != null)
            {
               
                movieResponse.Categories = movie.MovieCategories.
                    Select(t=> t.Category.CategoryName).
                    ToList().ToArray();
            }
            return movieResponse;

        }

        public async Task<MoviesResponse> UpdateMovie(Guid id, MovieUpdateRequest moviesUpdateRequest)
        {
            var movie = _moviesRepository.GetAsync(id).Result;
            var entity=_mapper.Map<Movie>(moviesUpdateRequest);
            entity.ImagePath = movie.ImagePath;
            entity.VideoPath = movie.VideoPath;
            entity.TrailerPath = movie.TrailerPath;
            entity.MovieId=movie.MovieId;
            await _movieCastsRepository.DeleteAll(movie.MovieId);
            await _movieCategoriesRepository.DeleteAll(movie.MovieId);
            entity.MovieCasts = await GetMovieCastsFromArray(movie.MovieId,moviesUpdateRequest?.Casts);
            entity.MovieCategories=await GetMovieCategoriesFromArray(movie.MovieId,moviesUpdateRequest?.Categories);    
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Movie, Movie>()).CreateMapper();            
            mapper.Map(entity, movie);           
            await _moviesRepository.UpdateAsync(movie);
            return _mapper.Map<MoviesResponse>(movie);
        }

        public  async Task<MoviesResponse> UploadVideos(Guid id, string? image, string? trailer, string? video)
        {
                     
            Movie movie = await _moviesRepository.GetAsync(id);
            if(image == null && trailer == null && video == null)
            {
                throw new Error("Please Provide atleast 1 file") ;
            } 
            if (image != null)
                movie.ImagePath = image;
            if (trailer != null)
                movie.TrailerPath = trailer;
            if (video != null)
                movie.VideoPath = video;
           await _moviesRepository.UpdateAsync(movie);
            return  await GetMovieAsync(id);

        }

        public async Task<string> GetMovieVideoPath(Guid id)
        {
          if(id == Guid.Empty)
            {
                throw new Error("MovieId is Empty");
            }
            var movie =await _moviesRepository.GetAsync(id);
            return movie.VideoPath;
        }

        public async Task<string> GetTrailerPath(Guid id)
        {
            if (id == Guid.Empty)
            {
                throw new Error("MovieId is Empty");
            }
            var movie = await _moviesRepository.GetAsync(id);
            return movie.TrailerPath;
        }
        #endregion
    }
}
