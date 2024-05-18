using AutoMapper;
using Bfl.Netflix.Core.Domain.Entities;
using Bfl.Netflix.Core.Domain.Entities.Relationships;
using Bfl.Netflix_Movies.Core.DTO.TvShowCast;
using Bfl.Netflix_Movies.Core.DTO.TvShowCategory;
using Bfl.Netflix_Movies.Core.Protos;
using Bfl.Netflix_Service1.Core.DTO.Accounts;
using Bfl.Netflix_Service1.Core.DTO.Movies;
using Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bfl.Netflix.Core.Configurations
{
    public class AutoMapperConfiguration : Profile
    {
        public AutoMapperConfiguration()
        {
            CreateMap<Movie,MoviesResponse>().ReverseMap();
            CreateMap<Movie, MovieUpdateRequest>().ReverseMap();
            CreateMap<Movie, MoviesAddRequest>().ReverseMap();
            CreateMap<ApplicationUser, RegisterRequest>().ReverseMap();
            CreateMap<ApplicationUser, RegisterResponse>().ReverseMap();
            /* CreateMap<TvRequestResponse, TvShowCastRequest>().ReverseMap().ForMember(dest => dest.CastsId, opt => opt.MapFrom(src => src.Casts)); 
             CreateMap<TvRequestResponse, TvShowCastResponse>().ReverseMap().ForMember(dest => dest.CastsId, opt => opt.MapFrom(src => src.Casts));
             CreateMap<TvRequestResponse, TvShowCategoryRequest>().ReverseMap().ForMember(dest => dest.CategoriesId, opt => opt.MapFrom(src => src.Categories));
             CreateMap<TvRequestResponse, TvShowCategoryResponse>().ReverseMap().ForMember(dest => dest.CategoriesId, opt => opt.MapFrom(src => src.Categories)); 
                */
            CreateMap<Cast, GetAllCastsOrCategoryResponse>().
                 ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.CastId.ToString())).
                 ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.CastName));
            CreateMap<Category, GetAllCastsOrCategoryResponse>().
                 ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.CategoryId.ToString())).
                 ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.CategoryName));

        }
    }
}
