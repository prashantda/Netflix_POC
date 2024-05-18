using Bfl.Netflix.Core.Domain.Entities.Relationships;
using Bfl.Netflix.Core.Domain.RepositoryContracts;
using Bfl.Netflix_Movies.Core.DTO.TvShowCategory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bfl.Netflix_Movies.Core.ServiceContracts
{
    public interface ITvShowCategoriesService 
    {
        Task<TvShowCategoryResponse> AddAsync(TvShowCategoryRequest request);
        Task<TvShowCategoryResponse> DeleteAsync(Guid tvShowId);
        Task<TvShowCategoryResponse> GetAsync(Guid tvShowId);
    }
}
