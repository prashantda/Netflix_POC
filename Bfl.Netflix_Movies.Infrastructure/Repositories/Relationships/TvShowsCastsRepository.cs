using Bfl.Netflix.Core.Domain.Entities.Relationships;
using Bfl.Netflix.Core.Domain.RepositoryContracts;
using Bfl.Netflix.Infrastructure.Database;
using Bfl.Netflix.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bfl.Netflix_Movies.Infrastructure.Repositories.Relationships
{
    public class TvShowsCastsRepository : GenericRepository<TvShowCast>, ITvShowCastsRepository
    {
        private readonly ApplicationDbContext _context;
        public TvShowsCastsRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<TvShowCast>> DeleteAll(Guid tvShowId)
        {
            var list = _context.TvShowCasts.Where(t => t.TvShowId == tvShowId).ToList();
            _context.RemoveRange(list);
            await _context.SaveChangesAsync();
            return list;
        }

        public async Task<IEnumerable<TvShowCast>> GetAllCastsById(Guid tvShowId)
        {
         return _context.TvShowCasts.Where(t => t.TvShowId == tvShowId).ToList();
        }
    }
}
