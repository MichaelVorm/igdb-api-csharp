using IgdbApi.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IgdbApi.Services
{
    public interface IApiService
    {
        Game GetGameById(int id);
        List<Game> SearchGamesByName(string name);
        Character GetCharacterById(int id);
        List<Character> SearchCharactersByName(string name);
        GameCollection GetGameCollectionById(int id);
        List<GameCollection> SeachGameCollectionsByName(string name);
    }
}