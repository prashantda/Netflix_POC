
using Bfl.Netflix_Tv.Core.Domain.Entities;
using Bfl.Netflix_Tv.Core.Domain.RepositoryContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bfl.Netflix_Tv.Infrastructure.Repositories
{
    public class EpisodesRepository : IEpisodesRepository
    {
        public Task<Episode> AddAsync(Episode entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Exists(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Episode>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Episode> GetAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Episode entity)
        {
            throw new NotImplementedException();
        }
    }
}
