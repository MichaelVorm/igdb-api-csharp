using IgdbApi.Dto;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace IgdbApi
{
    public class ApiClient : IApiClient
    {
        private  HttpClient _apiClient { get; set; }
        private AppSettings _appSettings { get; set; }

        public ApiClient(IOptions<AppSettings> appSettings)
        {
            _appSettings = appSettings.Value;
            _apiClient = new HttpClient
            {
                BaseAddress = new Uri(_appSettings.EndPoint)
            };
            _apiClient.DefaultRequestHeaders.Add("user-key", _appSettings.UserKey);
            _apiClient.DefaultRequestHeaders.Add("Accept", "application/json");
        }

        public async Task<T> Get<T>(string requestUri)
        {
            try
            {
                var response = await _apiClient.GetAsync(requestUri);

                string stringResult = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<T>(stringResult);
                return result;
            }
            catch (HttpRequestException httpRequestException)
            {
                throw httpRequestException;
            }
        }
    }
}
