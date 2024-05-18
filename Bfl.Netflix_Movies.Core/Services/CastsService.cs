using Bfl.Netflix.Core.Domain.Entities;
using Bfl.Netflix.Core.Domain.RepositoryContracts;
using Bfl.Netflix_Service1.Core.DTO.Casts;
using Bfl.Netflix_Service1.Core.ServiceContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bfl.Netflix_Service1.Core.Services
{
    public class CastsService : ICastsService
    {
        public readonly ICastsRepository _castsRepository;
        public CastsService(ICastsRepository castsRepository)
        {
            _castsRepository = castsRepository;
        }

       

        public async Task<CastResponse> AddAsync(string cast)
        {
            var entity=new Cast() { CastId=Guid.NewGuid(),CastName=cast};
           await _castsRepository.AddAsync(entity);
            return new CastResponse() { castName = entity.CastName, castId = entity.CastId };
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            var entity= await _castsRepository.GetAsync(id);
            if (entity == null)
            {
                throw new ArgumentException("Id not valid");
            }
            await _castsRepository.DeleteAsync(id);
            return true;
        }

        public async Task<IEnumerable<string>> GetAll()
        {
            var list = await _castsRepository.GetAllAsync();
            var casts=new List<string>();
            casts = list.Select(t => t.CastName).ToList();
            return casts;
        }

        public async Task<string> GetByIdAsync(Guid id)
        {
          var  entity=await _castsRepository.GetAsync(id);
            if(entity == null)
            {
                throw new ArgumentException("Cast does not exist with given id");
            }
            return entity.CastName;
        }

        public async Task<CastResponse> UpdateAsync(Guid id, string cast)
        {
            var entity = await _castsRepository.GetAsync(id);
            if (entity == null)
            {
                throw new ArgumentException("Cast does not exist with given id");
            }
            entity.CastName = cast;
            await _castsRepository.UpdateAsync(entity);
            return new CastResponse() { castName = entity.CastName, castId = entity.CastId };
        }
        
        public async Task AddAll(IEnumerable<CastResponse> castRequest)
        {
           await _castsRepository.DeleteAll();
            var casts=castRequest.Select(t=>new Cast() { CastId=t.castId,CastName=t.castName}).ToList();
            foreach(Cast cast in casts)
            {
                await _castsRepository.AddAsync(cast);
            }
            
        }
    }
}
