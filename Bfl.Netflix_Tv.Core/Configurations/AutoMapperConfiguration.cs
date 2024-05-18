using AutoMapper;
using Bfl.Netflix_Tv.Core.Domain.Entities;
using Bfl.Netflix_Tv.Core.DTO.Shared;
using Bfl.Netflix_Tv.Core.DTO.TvShow;
using Bfl.Netflix_Tv.Core.DTO.TvShowCast;
using Bfl.Netflix_Tv.Core.DTO.TvShowCategory;
using Configurations;

namespace Bfl.Netflix_Tv.Core.Configurations
{
    public class AutoMapperConfiguration : Profile
    {
        public AutoMapperConfiguration()
        {
             CreateMap<TvShowAddRequest,TvShow>().ReverseMap();
            CreateMap<TvShowResponse,TvShow>().ReverseMap();
            CreateMap<TvShowUpdateRequest,TvShow>().ReverseMap();
            /*CreateMap<TvRequestResponse, TvShowCastRequest>().ReverseMap().ForMember(dest => dest.CastsId, opt => opt.MapFrom(src => src.Casts));
            CreateMap<TvRequestResponse, TvShowCastResponse>().ReverseMap().ForMember(dest => dest.CastsId, opt => opt.MapFrom(src => src.Casts));
            CreateMap<TvRequestResponse, TvShowCategoryRequest>().ReverseMap().ForMember(dest => dest.CategoriesId, opt => opt.MapFrom(src => src.Categories));
            CreateMap<TvRequestResponse, TvShowCategoryResponse>().ReverseMap().ForMember(dest => dest.CategoriesId, opt => opt.MapFrom(src => src.Categories));*/
            CreateMap<Protos.GetAllCastsOrCategoryResponse, CastOrCategoryDTO>();
                
        }
    }
}
