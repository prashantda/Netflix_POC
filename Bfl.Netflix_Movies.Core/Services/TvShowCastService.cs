using AutoMapper;
using Azure.Core;
using Bfl.Netflix.Core.Domain.Entities.Relationships;
using Bfl.Netflix.Core.Domain.RepositoryContracts;
using Bfl.Netflix_Movies.Core.DTO.TvShowCast;
using Bfl.Netflix_Movies.Core.ServiceContracts;
using Bfl.Netflix_Service1.Core.DTO.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bfl.Netflix_Movies.Core.Services
{
    public class TvShowCastService : ITvShowsCastService
    {
        private readonly ITvShowCastsRepository _tvShowsCastRepository;
        private readonly IMapper _mapper;
        private readonly ICastsRepository _castsRepository;

        public TvShowCastService(ITvShowCastsRepository tvShowsCastRepository,IMapper mapper, ICastsRepository castsRepository)
        {
            _tvShowsCastRepository = tvShowsCastRepository;
            _mapper=mapper;
            _castsRepository = castsRepository;
        }
        public async Task<TvShowCastResponse> AddAsync(TvShowCastRequest request)
        {
            if(request == null)
            {
                throw new Error("Reqest object is null in Saving TvShowCast");
            }
            TvShowCast tvShowCast =new TvShowCast();
            TvShowCastResponse response=new TvShowCastResponse();
            foreach (var cast in request.Casts)
            {
                tvShowCast.TvShowId=request.TvShowId;
                tvShowCast.CastId = cast;
                tvShowCast.Id = Guid.NewGuid();
                await _tvShowsCastRepository.AddAsync(tvShowCast);
                var castResponse = await _castsRepository.GetAsync(cast);
                response.Casts.Add(castResponse.CastName);
            }
            response.TvShowId=request.TvShowId; 
            return response;         
        }

        public async Task<TvShowCastResponse> DeleteAsync(Guid tvShowId)
        {
            if(tvShowId == null)
            {
                throw new Error("Please provide valid id");
            }
            var allCasts =await _tvShowsCastRepository.DeleteAll(tvShowId);
            var list =new TvShowCastResponse();
            list.TvShowId = tvShowId;
            var guidCastList=allCasts.Select(t=>t.CastId).ToList();
            foreach (var cast in guidCastList)
            {
                var castResponse = await _castsRepository.GetAsync(cast);
                list.Casts.Add(castResponse.CastName);
            }
            return list;
        }

        public async Task<TvShowCastResponse> GetAsync(Guid tvShowId)
        {
            if (tvShowId == null)
            {
                throw new Error("Please provide valid id");
            }
            var allCasts = await _tvShowsCastRepository.GetAllCastsById(tvShowId);
            var list = new TvShowCastResponse();
            list.TvShowId = tvShowId;
            var guidCastList = allCasts.Select(t => t.CastId).ToList();
            foreach (var cast in guidCastList)
            {
                var castResponse = await _castsRepository.GetAsync(cast);
                list.Casts.Add(castResponse.CastName);
            }
            return list;
        }
    }
}
