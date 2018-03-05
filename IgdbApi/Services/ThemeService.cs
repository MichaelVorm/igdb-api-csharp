using IgdbApi.Dto;
using IgdbApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IgdbApi.Services
{
    public class ThemeService : IThemeService
    {
        private IApiClient _apiClient;

        public ThemeService(IApiClient apiClient)
        {
            _apiClient = apiClient;
        }

        public Theme GetThemeById(int id)
        {
            string requestUri = string.Format("/themes/{0}?fields=*", id);
            var theme = _apiClient.Get<List<Theme>>(requestUri).Result;

            return theme[0];
        }

        public List<Theme> SearchThemesByName(string name)
        {
            string requestUri = string.Format("/themes/?search={0}&fields=*", name);
            var themes = _apiClient.Get<List<Theme>>(requestUri).Result;

            return themes;
        }
    }
}
