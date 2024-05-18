using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace Bfl.Netflix_Tv.Core.Configurations
{
    public static class Endpoints
    {

        public static string Host { get; set; } = string.Concat("http://", Environment.GetEnvironmentVariable("CLIENTHOST") ?? "localhost:5069","/api/movie/");
        public static string SaveTvshowCast { get; set; }= Endpoints.Host + "TVShowCast/Add";
        public static string SaveTvshowCategory { get;  set; }= Endpoints.Host + "TVShowCategory/Add";
        public static string DeleteTvshowCategory { get; set; } = Endpoints.Host + "TVShowCategory/Delete";
        public static string DeleteTvshowCast { get; set; } = Endpoints.Host + "TVShowCast/Delete";
        public static string GetTvshowCategory { get; set; } = Endpoints.Host + "TVShowCategory/Get";
        public static string GetTvshowCast { get; set; } = Endpoints.Host + "TVShowCast/Get";
        public static string GRPCUrl { get; set; } 

        public static string KafkaServer { get; set; }


    }
}
