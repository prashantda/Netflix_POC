using AutoMapper;
using Bfl.Netflix_Tv.Core.DTO.Shared;
using Bfl.Netflix_Tv.Core.DTO.TvShowCast;
using Configurations;
using MassTransit;
using MassTransit.Transports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Action = Configurations.Action;

namespace Bfl.Netflix_Tv.Core.AsyncDataServices
{
    public class RmqTvShowCastDataClient  : IRmqTvShowDataClient
    {
        private readonly IBus _bus;
        private readonly IMapper _mapper;
        private readonly ISendEndpoint _endpoint;
        private readonly IBusControl _busControl;

        public  RmqTvShowCastDataClient(IBus bus,IMapper mapper,IBusControl busControl)
        {
            _bus= bus;  
            _mapper=mapper;
             _endpoint =  bus.GetSendEndpoint(new Uri(RabbitMqConfiguration.QueueUrl)).Result;
            //_busControl= busControl;   
        }

         public async Task AddTvShowCast(TvRequestResponse request)
         {
             request.Action = Action.AddCasts;
             await _endpoint.Send(request);

         }
       

    }
}
