using AutoMapper;
using Bfl.Netflix.Core.Domain.Entities;
using Bfl.Netflix.Core.Domain.RepositoryContracts;
using Bfl.Netflix_Movies.Core.Protos;
using Grpc.Core;
using MassTransit.Initializers;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bfl.Netflix_Movies.Core.SyncDataServices.GRPC
{
   
    public class GrpcMoviesService : GrpcAllCastsOrCategories.GrpcAllCastsOrCategoriesBase   //GrpcAllCastsOrCategories namespace is equal to service name in protos file
    {
        private readonly ICastsRepository _castRepository;
        private readonly ICategoriesRepository _categoriesRepository;
        private readonly IMapper _mapper;

        public GrpcMoviesService(ICastsRepository castsRepository,ICategoriesRepository categoriesRepository,IMapper mapper)
        {
            _castRepository = castsRepository;
            _categoriesRepository = categoriesRepository;
            _mapper = mapper;
        }

        public override async Task<MultipleResponses> GetAllCastsOrCategories(GetAllCastsOrCategoryRequest request, ServerCallContext context)
        {
            var response=new MultipleResponses();
            if(request.Needed == nameof(Cast))
            {
                var casts =await _castRepository.GetAllAsync();

                foreach (var cast in casts)
                {
                    response.Castsorcategories.Add(_mapper.Map<GetAllCastsOrCategoryResponse>(cast));
                }
                return response;
            }
            if (request.Needed == nameof(Category))
            {
                var categories = await _categoriesRepository.GetAllAsync();

                foreach (var category in categories)
                {
                    response.Castsorcategories.Add(_mapper.Map<GetAllCastsOrCategoryResponse>(category));
                }
                return response;
            }

            return response;

        }
    }
}
