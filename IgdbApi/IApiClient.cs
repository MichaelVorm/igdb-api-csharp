using IgdbApi.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IgdbApi
{
    public interface IApiClient
    {
        List<Game> GetGameById(int id);
        List<Game> SearchGameByName(string name);
    }
}
