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
    public class MovieCastsRepository : GenericRepository<MovieCast>, IMovieCastsRepository
    {
        public readonly ApplicationDbContext _context;
        public MovieCastsRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
        public async Task DeleteAll(Guid movieId)
        {
            var movieCasts=await _context.MovieCasts.Where(t => t.MovieId==movieId).ToListAsync();
            _context.MovieCasts.RemoveRange(movieCasts);
           await _context.SaveChangesAsync();
            
        }


    }
}
