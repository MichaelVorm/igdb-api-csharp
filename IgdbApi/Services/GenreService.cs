using IgdbApi.Dto;
using IgdbApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IgdbApi.Services
{
    public class GenreService : IGenreService
    {
        private IApiClient _apiClient;

        public GenreService(IApiClient apiClient)
        {
            _apiClient = apiClient;
        }

        public Genre GetGenreById(int id)
        {
            string requestUri = string.Format("/genres/{0}?fields=*", id);
            var genre = _apiClient.Get<List<Genre>>(requestUri).Result;

            return genre[0];
        }

        public List<Genre> SearchGenresByName(string name)
        {
            string requestUri = string.Format("/genres/?search={0}&fields=*", name);
            var genres = _apiClient.Get<List<Genre>>(requestUri).Result;

            return genres;
        }
    }
}
