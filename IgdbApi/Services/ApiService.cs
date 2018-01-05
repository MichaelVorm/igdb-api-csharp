using IgdbApi.Dto;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace IgdbApi.Services
{
    public class ApiService : IApiService
    {    
        private IApiClient _apiClient;

        public ApiService(IApiClient apiClient)
        {
            _apiClient = apiClient;
        }

        public List<Game> GetGameById(int id)
        {
            var game = _apiClient.GetGameById(id);
            return game;
        }

        public List<Game> SearchGameByName(string name)
        {
            var game = _apiClient.SearchGameByName(name);
            return game;
        }
    }
}
