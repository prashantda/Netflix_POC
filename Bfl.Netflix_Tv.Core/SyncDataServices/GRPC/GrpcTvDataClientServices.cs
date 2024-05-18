using AutoMapper;
using Bfl.Netflix_Tv.Core.Configurations;
using Bfl.Netflix_Tv.Core.DTO.Shared;
using Bfl.Netflix_Tv.Core.DTO.TvShowCategory;
using Bfl.Netflix_Tv.Core.Protos;
using Configurations;
using Grpc.Core;
using Grpc.Net.Client;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bfl.Netflix_Tv.Core.SyncDataServices.GRPC
{
    public class GrpcTvDataClientServices : IGrpcTvDataClientServices
    {
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;
        private readonly ILogger<GrpcTvDataClientServices> _logger;

        public GrpcTvDataClientServices(IConfiguration configuration,IMapper mapper,ILogger<GrpcTvDataClientServices> logger)
        {
            _mapper = mapper;
            _configuration = configuration;
            _logger = logger;
        }

        public async Task<IEnumerable<CastOrCategoryDTO>> GetAllCastsOrCategories(string action,string token)
        {
            var headers = new Metadata();
            headers.Add("Authorization", token);
            var channel = GrpcChannel.ForAddress(Endpoints.GRPCUrl);
            var client = new GrpcAllCastsOrCategories.GrpcAllCastsOrCategoriesClient(channel);
            var request = new GetAllCastsOrCategoryRequest();
            request.Needed = action;
            var response=  client.GetAllCastsOrCategories(request, headers);

            return _mapper.Map<IEnumerable<CastOrCategoryDTO>>(response.Castsorcategories);
         }

       
    }
}
