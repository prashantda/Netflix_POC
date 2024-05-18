using Bfl.Netflix.Core.Domain.Entities.Relationships;
using Bfl.Netflix.Core.Domain.RepositoryContracts;
using Bfl.Netflix.Infrastructure.Database;
using Bfl.Netflix.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bfl.Netflix_Movies.Infrastructure.Repositories.Relationships
{
    public class TvShowCategoryRepository : GenericRepository<TvShowCategory>, ITvShowCategoriesRepository
    {
        private readonly ApplicationDbContext _context;
        public TvShowCategoryRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
        public async Task<IEnumerable<TvShowCategory>> DeleteAll(Guid tvShowId)
        {
            var list = _context.TvShowCategories.Where(t => t.TvShowId == tvShowId).ToList();
            _context.RemoveRange(list);
            await _context.SaveChangesAsync();
            return list;
        }

        public async Task<IEnumerable<TvShowCategory>> GetAllCategoriesById(Guid tvShowId)
        {
            return _context.TvShowCategories.Where(t => t.TvShowId == tvShowId).ToList();
        }
    }
}
