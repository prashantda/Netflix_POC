using Bfl.Netflix_Tv.Core.Configurations;
using Bfl.Netflix_Tv.Core.DTO.Shared;
using Bfl.Netflix_Tv.Core.DTO.TvShowCast;
using Bfl.Netflix_Tv.Core.DTO.TvShowCategory;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;

namespace Bfl.Netflix_Tv.Core.SyncDataServices
{
    public class HttpTvShowCastDataClient : ITvShowCastDataServices
    {
        private readonly HttpClient _client;

        public HttpTvShowCastDataClient(HttpClient client)
        {
            _client = client;
        }
        public async Task<Response<TvShowCastResponse>> AddAsync(TvShowCastRequest tvShowCastrequest,string token)
        {
            var requestContent=new StringContent(
                JsonConvert.SerializeObject(tvShowCastrequest),
                Encoding.UTF8,
                "application/json");

            var request = new HttpRequestMessage(HttpMethod.Post, Endpoints.SaveTvshowCast);
            request.Content = requestContent;
            request.Headers.Add("Authorization", token);
            var response= await _client.SendAsync(request);

            if (response.IsSuccessStatusCode)
            {
                string myResponse =await  response.Content.ReadAsStringAsync();
                Response<TvShowCastResponse> result = JsonConvert.DeserializeObject<Response<TvShowCastResponse>>(myResponse);
                return result;
            }
            throw new Error("Something went wrong while saving TvShowCast from TvService to MoviesService");
            
        }

        public async Task<Response<TvShowCastResponse>> DeleteOrGetAsync(Guid id, string token, string method)
        {
            var genericRequest = new GenericRequest(id);
            HttpRequestMessage request = null;
            var stringContent = new StringContent(
                JsonConvert.SerializeObject(genericRequest),
                Encoding.UTF8,
                "application/json");
            string url = string.Concat("?tvShowId =", id);
            
            if (method == Endpoints.DeleteTvshowCast)
            {
                 request = new HttpRequestMessage(HttpMethod.Delete, Endpoints.DeleteTvshowCast);
            }
            if(method == Endpoints.GetTvshowCast)
            {
                 request = new HttpRequestMessage(HttpMethod.Get, Endpoints.GetTvshowCast);
            }
           
           request.Content= stringContent;
            request.Headers.Add("Authorization", token);
            var response = await _client.SendAsync(request);

            if (response.IsSuccessStatusCode)
            {
                string myResponse = await response.Content.ReadAsStringAsync();
                Response<TvShowCastResponse> result = JsonConvert.DeserializeObject<Response<TvShowCastResponse>>(myResponse);
                return result;
            }
            throw new Error("Something went wrong while requesting resource TvShowCast from TvService to MoviesService");

        }

        
    }
}
