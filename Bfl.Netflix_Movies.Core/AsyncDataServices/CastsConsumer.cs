using AutoMapper;
using Bfl.Netflix_Movies.Core.DTO.TvShowCast;
using Bfl.Netflix_Movies.Core.ServiceContracts;
using Configurations;
using MassTransit;
using Newtonsoft.Json;
using System.Text.Json;
using System.Text.Json.Serialization;
using Action = Configurations.Action;

namespace Bfl.Netflix_Movies.Core.AsyncDataServices
{
    public class CastsConsumer :  IConsumer<IRequestResponse>
    {
        private readonly ITvShowsCastService _tvShowsCastService;
        private readonly IMapper _mapper;

        public CastsConsumer(ITvShowsCastService tvShowsCastService,IMapper mapper)
        {
            _tvShowsCastService = tvShowsCastService;
            _mapper = mapper;

        }

        public async Task Consume(ConsumeContext<IRequestResponse> context)
        {
            
              switch(context.Message.Action)
            {
                case Action.AddCasts:
                    {
                        TvShowCastRequest entity=new TvShowCastRequest()
                        {
                            Casts=context.Message.CastsId,TvShowId=context.Message.TvShowId
                        };
                        await _tvShowsCastService.AddAsync(entity);
                        break;

                     }

                default : break;
            } 




        }
        
    }
}
