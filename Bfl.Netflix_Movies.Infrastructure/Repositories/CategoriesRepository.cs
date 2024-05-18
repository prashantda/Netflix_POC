using Bfl.Netflix.Core.Domain.Entities;
using Bfl.Netflix.Core.Domain.RepositoryContracts;
using Bfl.Netflix.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;


namespace Bfl.Netflix.Infrastructure.Repositories
{
    public class CategoriesRepository :GenericRepository<Category>,ICategoriesRepository
    {
        private readonly ApplicationDbContext _context;
        public CategoriesRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Category> GetByNameAsync(string name)
        {
            return await _context.Categories.FirstOrDefaultAsync(temp => temp.CategoryName == name);
        }
        public async Task<int> CountAsync()
        {
            return await _context.Categories.CountAsync();
        }
    }
}




