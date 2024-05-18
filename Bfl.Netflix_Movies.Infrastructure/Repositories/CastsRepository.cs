using Bfl.Netflix.Core.Domain.Entities;
using Bfl.Netflix.Core.Domain.RepositoryContracts;
using Bfl.Netflix.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bfl.Netflix.Infrastructure.Repositories
{
    public class CastsRepository : GenericRepository<Cast>, ICastsRepository
    {
        private readonly ApplicationDbContext _context;
        public CastsRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<int> CountAsync()
        {
         return await  _context.Casts.CountAsync();
        }

        public async Task DeleteAll()
        {
            var list = await _context.Casts.ToListAsync();
            _context.Casts.RemoveRange(list);
           await _context.SaveChangesAsync();
        }

        public async Task<Cast> GetCastByNameAsync(string name)
        {
          return await  _context.Casts.FirstOrDefaultAsync(temp => temp.CastName == name);
        }
    }
}
