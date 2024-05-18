using AutoMapper;
using Bfl.Netflix_Tv.Core.AsyncDataServices;
using Bfl.Netflix_Tv.Core.Configurations;
using Bfl.Netflix_Tv.Core.Domain.Entities;
using Bfl.Netflix_Tv.Core.Domain.RepositoryContracts;
using Bfl.Netflix_Tv.Core.DTO.Shared;
using Bfl.Netflix_Tv.Core.DTO.TvShow;
using Bfl.Netflix_Tv.Core.DTO.TvShowCast;
using Bfl.Netflix_Tv.Core.DTO.TvShowCategory;
using Bfl.Netflix_Tv.Core.ServiceContracts;
using Bfl.Netflix_Tv.Core.SyncDataServices;
using Configurations;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bfl.Netflix_Tv.Core.Services
{
    public class TvShowService : ITvShowsService
    {
        private readonly ITvShowsRepository _tvShowsRepository;
        private readonly IMapper _mapper;
        private readonly ILogger<TvShowService> _logger;
        private readonly ITvShowCastDataServices _castClient;
        private readonly ITvShowCategoryDataServices _categoryClient;
        private readonly IRmqTvShowDataClient _rmqClient;
        private readonly IKfkaTvCategoryClient _kafkaClient;

        public TvShowService(ITvShowsRepository tvShowsRepository,
            IMapper mapper,ILogger<TvShowService> logger,ITvShowCastDataServices castClient
            ,ITvShowCategoryDataServices categoryClient,
            IRmqTvShowDataClient rmqClient,
            IKfkaTvCategoryClient kafkaClient) {
            _tvShowsRepository = tvShowsRepository;
            _mapper= mapper;
            _logger= logger;
            _castClient = castClient;
            _categoryClient = categoryClient;
            _rmqClient= rmqClient;
            _kafkaClient = kafkaClient;
        }
        public async Task<TvShowResponse> AddAsync(TvShowAddRequest tvAddRequest,string token)
        {
            _logger.LogInformation("InComing AddAsync () of TvShowService");
            TvShow tv = _mapper.Map<TvShow>(tvAddRequest);
           tv=await _tvShowsRepository.AddAsync(tv);

             TvRequestResponse saveCastRequest= new TvRequestResponse() {TvShowId=tv.TvShowId,CastsId=tvAddRequest.Casts };
            TvShowCategoryRequest saveCategoryRequest=new TvShowCategoryRequest() { Categories= tvAddRequest.Categories,TvShowId=tv.TvShowId};
            // var savedCastResponse = await _castClient.AddAsync(saveCastRequest,token);
            // await _rmqClient.AddTvShowCast(saveCastRequest);
            //   var savedCategoryResponse = await _categoryClient.AddAsync(saveCategoryRequest, token);

          await  _kafkaClient.AddTvShowCast(saveCategoryRequest);
            var response = _mapper.Map<TvShowResponse>(tv);
           // response.Casts = savedCastResponse.Data.Casts.ToArray();
         //   response.Categories= savedCategoryResponse.Data.Categories.ToArray();

            _logger.LogInformation("Outgoing AddAsync () of TvShowService");
            return response;
        }

        public  async Task<TvShowResponse> DeleteAsync(Guid id,string token)
        {
            if (id == null)
            {
                throw new Error("Id is null");
            }
            _logger.LogInformation("InComing DeleteAsync () of TvShowService");
           var tv = await _tvShowsRepository.GetAsync(id);
            if (tv == null)
                throw new Error("TvShow not found with given id");
            var response = _mapper.Map<TvShowResponse>(tv);
            //await _tvShowsRepository.DeleteAsync(id); if you uncomment this no need to call below two postasync method cause it will delete on cascade i.e cast n categories will be deleted automatically due to foreign key
            var caststList = await _castClient.DeleteOrGetAsync(id, token, Endpoints.DeleteTvshowCast);
            var categoryList = await _categoryClient.DeleteOrGetAsync(id, token, Endpoints.DeleteTvshowCategory);
            response.Casts = caststList.Data.Casts.ToArray();
            response.Categories = categoryList.Data.Categories.ToArray();
            await _tvShowsRepository.DeleteAsync(id);// this will delete tvshow only cause cast n category r deleted by above two
            

            return response;
        }

        

        public Task<IEnumerable<TvShowResponse>> GetAllAsync(string token)
        {
            throw new NotImplementedException();
        }

        public async Task<TvShowResponse> GetAsync(Guid id,string token)
        {
            _logger.LogInformation("InComing getAsync () of TvShowService");
            var tv =await _tvShowsRepository.GetAsync(id);
            var tvResponse = _mapper.Map<TvShowResponse>(tv);
           var caststList =   await _castClient.DeleteOrGetAsync(id, token, Endpoints.GetTvshowCast);
          var categoryList=  await _categoryClient.DeleteOrGetAsync(id, token, Endpoints.GetTvshowCategory);
            tvResponse.Casts = caststList.Data.Casts.ToArray();
            tvResponse.Categories = categoryList.Data.Categories.ToArray();
            return tvResponse;
        }

        public Task<TvShowResponse> UpdateAsync(TvShowUpdateRequest tv, string token)
        {
            throw new NotImplementedException();
        }
    }
}
