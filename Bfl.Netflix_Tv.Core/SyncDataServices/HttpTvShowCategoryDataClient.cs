using Bfl.Netflix_Tv.Core.Configurations;
using Bfl.Netflix_Tv.Core.DTO.Shared;
using Bfl.Netflix_Tv.Core.DTO.TvShowCategory;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bfl.Netflix_Tv.Core.SyncDataServices
{
    public class HttpTvShowCategoryDataClient : ITvShowCategoryDataServices
    {
        private readonly HttpClient _client;

        public HttpTvShowCategoryDataClient(HttpClient client)
        {
            _client = client;
        }

        public async Task<Response<TvShowCategoryResponse>> AddAsync(TvShowCategoryRequest tvShowCategoryrequest, string token)
        {
            var requestContent = new StringContent(
                JsonConvert.SerializeObject(tvShowCategoryrequest),
                Encoding.UTF8,
                "application/json");

            var request = new HttpRequestMessage(HttpMethod.Post, Endpoints.SaveTvshowCategory);
            request.Content = requestContent;
            request.Headers.Add("Authorization", token);
            var response = await _client.SendAsync(request);

            if (response.IsSuccessStatusCode)
            {
                string myResponse = await response.Content.ReadAsStringAsync();
                Response<TvShowCategoryResponse> result = JsonConvert.DeserializeObject<Response<TvShowCategoryResponse>>(myResponse);
                return result;
            }
            throw new Error("Something went wrong while saving TvShowCategory from TvService to MoviesService");

        }

        public async Task<Response<TvShowCategoryResponse>> DeleteOrGetAsync(Guid id, string token, string method)
        {
            var genericRequest = new GenericRequest(id);
            HttpRequestMessage request = new HttpRequestMessage();
            request.Content = new StringContent(
               JsonConvert.SerializeObject(genericRequest),
               Encoding.UTF8,
               "application/json");
            
            if (method == Endpoints.DeleteTvshowCategory)
            {
                request.Method = HttpMethod.Delete;
                request.RequestUri=new Uri( Endpoints.DeleteTvshowCategory);
            }
            if (method == Endpoints.GetTvshowCategory)
            {
                request.Method = HttpMethod.Get;
                request.RequestUri = new Uri(Endpoints.GetTvshowCategory);
                
            }
           
           
            request.Headers.Add("Authorization", token);
            var response = await _client.SendAsync(request);

            if (response.IsSuccessStatusCode)
            {
                string myResponse = await response.Content.ReadAsStringAsync();
                Response<TvShowCategoryResponse> result = JsonConvert.DeserializeObject<Response<TvShowCategoryResponse>>(myResponse);
                return result;
            }
            throw new Error("Something went wrong while deleting TvShowCategory from TvService to MoviesService");

        }
    }
}
