using AutoMapper;
using Bfl.Netflix.Core.Domain.Entities.Relationships;
using Bfl.Netflix.Core.Domain.RepositoryContracts;
using Bfl.Netflix_Movies.Core.DTO.TvShowCategory;
using Bfl.Netflix_Movies.Core.ServiceContracts;
using Bfl.Netflix_Movies.Core.Services;
using Bfl.Netflix_Service1.Core.DTO.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bfl.Netflix_Movies.Core.Services
{
    public class TvShowCategoriesService : ITvShowCategoriesService
    {
        private readonly ITvShowCategoriesRepository _tvShowCategoriesRepository;
        private readonly IMapper _mapper;
        private readonly ICategoriesRepository _categoriesRepository;

        public TvShowCategoriesService(ITvShowCategoriesRepository tvShowCategoriesRepository, 
            IMapper mapper, ICategoriesRepository categoriesRepository)
        {
            _tvShowCategoriesRepository = tvShowCategoriesRepository;
            _mapper = mapper;
            _categoriesRepository = categoriesRepository;

        }
        public async Task<TvShowCategoryResponse> AddAsync(TvShowCategoryRequest request)
        {
            if (request == null)
            {
                throw new Error("Reqest object is null in Saving TvShowCategory");
            }
            TvShowCategory tvShowCategory = new TvShowCategory();
            TvShowCategoryResponse response = new TvShowCategoryResponse();
            foreach (var category in request.Categories)
            {
                tvShowCategory.TvShowId = request.TvShowId;
                tvShowCategory.CategoryId = category;
                tvShowCategory.Id = Guid.NewGuid();
                await _tvShowCategoriesRepository.AddAsync(tvShowCategory);
                var categoryResponse = await _categoriesRepository.GetAsync(category);
                response.Categories.Add(categoryResponse.CategoryName);
            }
            response.TvShowId = request.TvShowId;
            return response;
        }

        public async Task<TvShowCategoryResponse> DeleteAsync(Guid tvShowId)
        {
            if (tvShowId == null)
            {
                throw new Error("Please provide valid id");
            }
            var allCategories = await _tvShowCategoriesRepository.DeleteAll(tvShowId);
            var list = new TvShowCategoryResponse();
            list.TvShowId = tvShowId;
            var guidCategoryList = allCategories.Select(t => t.CategoryId).ToList();
            foreach (var category in guidCategoryList)
            {
                var categoryResponse = await _categoriesRepository.GetAsync(category);
                list.Categories.Add(categoryResponse.CategoryName);
            }
            return list;
        }

        public async Task<TvShowCategoryResponse> GetAsync(Guid tvShowId)
        {
            if (tvShowId == null)
            {
                throw new Error("Please provide valid id");
            }
            var allCategories = await _tvShowCategoriesRepository.GetAllCategoriesById(tvShowId);
            var list = new TvShowCategoryResponse();
            list.TvShowId = tvShowId;
            var guidCategoryList = allCategories.Select(t => t.CategoryId).ToList();
            foreach (var category in guidCategoryList)
            {
                var categoryResponse = await _categoriesRepository.GetAsync(category);
                list.Categories.Add(categoryResponse.CategoryName);
            }
            return list;
        }
    }
}




