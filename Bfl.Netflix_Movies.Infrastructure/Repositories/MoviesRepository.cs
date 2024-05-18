using Bfl.Netflix.Core.Domain.Entities;
using Bfl.Netflix.Core.Domain.RepositoryContracts;
using Bfl.Netflix.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bfl.Netflix.Infrastructure.Repositories
{
    public class MoviesRepository : GenericRepository<Movie>, IMoviesRepository
    {
        private readonly ApplicationDbContext _context;
        public MoviesRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Movie> GetMovieWithCastNCategegoryAsync(Guid id)
        {
           return await _context.Movies.Include(t => t.MovieCasts).ThenInclude(t=>t.Casts).Include(t => t.MovieCategories).ThenInclude(t=>t.Category).FirstOrDefaultAsync(t=>t.MovieId==id);
        }
    }
}
