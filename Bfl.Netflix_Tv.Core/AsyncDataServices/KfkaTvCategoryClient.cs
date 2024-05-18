using Bfl.Netflix_Tv.Core.DTO.TvShowCategory;
using Bfl.Netflix_Tv.Core.Helpers;
using Confluent.Kafka;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bfl.Netflix_Tv.Core.AsyncDataServices
{
    public class KfkaTvCategoryClient : IKfkaTvCategoryClient
    {
        private readonly ProducerConfig _config;

        public KfkaTvCategoryClient(ProducerConfig config)
        {
            _config = config; 
        }
        public async Task AddTvShowCast(TvShowCategoryRequest request)
        {
            string requestObject=JsonConvert.SerializeObject(request);
            using  var producer = new ProducerBuilder<Null, string>(_config).Build();
            await producer.ProduceAsync(ConfigurationManager.AppSetting["KafkaProducer:topic"], new Message<Null, string> { Value = requestObject });
            producer.Flush(TimeSpan.FromSeconds(1));

        }
    }
}
