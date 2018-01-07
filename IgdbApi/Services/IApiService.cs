using IgdbApi.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IgdbApi.Services
{
    public interface IApiService
    {
        List<Game> GetGameById(int id);
        List<Game> SearchGamesByName(string name);
    }
}