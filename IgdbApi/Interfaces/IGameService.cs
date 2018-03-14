using IgdbApi.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IgdbApi.Interfaces
{
    public interface IGameService
    {

        Game GetGameById(int id);
        List<Game> SearchGamesByName(string name);
        GameEngine GetGameEngineById(int id);
        List<GameEngine> SearchGameEnginesByName(string name);
        GameMode GetGameModeById(int id);
        List<GameMode> SearchGameModesByName(string name);
        Character GetCharacterById(int id);
        List<Character> SearchCharactersByName(string name);
        Company GetCompanyById(int id);
        List<Company> SearchCompaniesByName(string name);
        Credit GetCreditById(int id);
        List<Credit> SearchCreditsByName(string name);
        Feed GetFeedById(int id);
        List<Feed> SearchFeedsByName(string name);
        Franchise GetFranchiseById(int id);
        List<Franchise> SearchFranchisesByName(string name);
        GameCollection GetGameCollectionById(int id);
        List<GameCollection> SearchGameCollectionsByName(string name);
        GameVersion GetGameVersionById(int id);
        List<GameVersion> SearchGameVersionsByName(string name);
        Genre GetGenreById(int id);
        List<Genre> SearchGenresByName(string name);
        Keyword GetKeywordById(int id);
        List<Keyword> SearchKeywordsByName(string name);
        Pulse GetPulseById(int id);
        List<Pulse> SearchPulsesByName(string name);
        PulseGroup GetPulseGroupById(int id);
        List<PulseGroup> SearchPulseGroupsByName(string name);
        PulseSource GetPulseSourceById(int id);
        List<PulseSource> SearchPulseSourcesByName(string name);
        Page GetPageById(int id);
        List<Page> SearchPagesByName(string name);
        Person GetPersonById(int id);
        List<Person> SearchPersonsByName(string name);
        Platform GetPlatformById(int id);
        List<Platform> SearchPlatformsByName(string name);
        PlayerPerspective GetPlayerPerspectiveById(int id);
        List<PlayerPerspective> SearchPlayerPerspectivesByName(string name);
        PlayTime GetPlayTimeById(int id);
        List<PlayTime> SearchPlayTimesByName(string name);
        GameReleaseDate GetReleaseDateById(int id);
        List<GameReleaseDate> SearchReleaseDatesByName(string name);
        Review GetReviewById(int id);
        List<Review> SearchReviewsByName(string name);
        Theme GetThemeById(int id);
        List<Theme> SearchThemesByName(string name);
        Title GetTitleById(int id);
        List<Title> SearchTitlesByName(string name);
        UserProfile GetUserProfileById(int id);
        List<UserProfile> SearchUserProfilesByName(string name);
    }
}
