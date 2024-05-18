using Bfl.Netflix.Core.Domain.Entities.Relationships;
using Bfl.Netflix.Core.Domain.RepositoryContracts;
using Bfl.Netflix.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bfl.Netflix.Infrastructure.Repositories.Relationships
{
    public class MovieCtegoriesRepository : GenericRepository<MovieCategory>, IMovieCategoriesRepository
    {
        public readonly ApplicationDbContext _context;
        public MovieCtegoriesRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
        public async Task DeleteAll(Guid movieId)
        {
            var movieCategories = await _context.MoviesCategories.Where(t => t.MovieId == movieId).ToListAsync();
            _context.MoviesCategories.RemoveRange(movieCategories);
             await _context.SaveChangesAsync();

        }
    }
}
