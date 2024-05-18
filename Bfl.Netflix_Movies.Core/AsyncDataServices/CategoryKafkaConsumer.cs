using Bfl.Netflix.Core.Configurations;
using Bfl.Netflix.Core.Helpers;
using Bfl.Netflix_Movies.Core.DTO.TvShowCategory;
using Bfl.Netflix_Movies.Core.Services;
using Confluent.Kafka;
using MassTransit.Transports;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bfl.Netflix_Movies.Core.AsyncDataServices
{
    public class CategoryKafkaConsumer : BackgroundService
    {
        //private readonly TvShowCategoriesService _tvShowCategoriesService;
         ConsumerConfig config = new ConsumerConfig() { GroupId = "netflix-bajaj",
            BootstrapServers = "localhost:9092",
            AutoOffsetReset = AutoOffsetReset.Earliest
        };

        public CategoryKafkaConsumer(/*TvShowCategoriesService tvShowCategoriesService*/)
        {
            //_tvShowCategoriesService = tvShowCategoriesService;
        }

        protected override async  Task ExecuteAsync(CancellationToken stoppingToken)
        {
           
            using var consumer= new ConsumerBuilder<Null,string>(config).Build();
            consumer.Subscribe(Netflix.Core.Helpers.ConfigurationManager.AppSetting["KafkaConsumer:topic"]);
            CancellationToken cancellationToken = new();
            while(!stoppingToken.IsCancellationRequested)
            {
                var request=  consumer.Consume(cancellationToken);
                if(request.Message != null)
                {
                    var requestObject = JsonConvert.DeserializeObject<TvShowCategoryRequest>(request.Message.Value);
                   // _tvShowCategoriesService.AddAsync(requestObject);
                }
            }
           
        }
    }
}

      