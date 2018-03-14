using IgdbApi.Dto;
using IgdbApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IgdbApi.Services
{
    public class GameService : IGameService
    {
        private IApiClient _apiClient;

        public GameService(IApiClient apiClient)
        {
            _apiClient = apiClient;
        }

        public Game GetGameById(int id)
        {
            string requestUri = string.Format("/games/{0}?fields=*", id);
            var game = _apiClient.Get<List<Game>>(requestUri).Result.SingleOrDefault();

            return game;
        }

        public List<Game> SearchGamesByName(string name)
        {
            string requestUri = string.Format("/games/?search={0}&fields=*", name);
            var games = _apiClient.Get<List<Game>>(requestUri).Result;

            return games;
        }

        public GameEngine GetGameEngineById(int id)
        {
            string requestUri = string.Format("/game_engines/{0}?fields=*", id);
            var gameEngine = _apiClient.Get<List<GameEngine>>(requestUri).Result.SingleOrDefault();

            return gameEngine;
        }

        public List<GameEngine> SearchGameEnginesByName(string name)
        {
            string requestUri = string.Format("/game_engines/?search={0}&fields=*", name);
            var gameEngines = _apiClient.Get<List<GameEngine>>(requestUri).Result;

            return gameEngines;
        }

        public GameMode GetGameModeById(int id)
        {
            string requestUri = string.Format("/game_modes/{0}?fields=*", id);
            var gameMode = _apiClient.Get<List<GameMode>>(requestUri).Result.SingleOrDefault();

            return gameMode;
        }

        public List<GameMode> SearchGameModesByName(string name)
        {
            string requestUri = string.Format("/game_modes/?search={0}&fields=*", name);
            var gameModes = _apiClient.Get<List<GameMode>>(requestUri).Result;

            return gameModes;
        }

        public Character GetCharacterById(int id)
        {
            string requestUri = string.Format("/characters/{0}?fields=*", id);
            var characters = _apiClient.Get<List<Character>>(requestUri).Result.SingleOrDefault();

            return characters;
        }

        public List<Character> SearchCharactersByName(string name)
        {
            string requestUri = string.Format("/characters/?search={0}&fields=*", name);
            var characters = _apiClient.Get<List<Character>>(requestUri).Result;

            return characters;
        }

        public Company GetCompanyById(int id)
        {
            string requestUri = string.Format("/companies/{0}?fields=*", id);
            var companies = _apiClient.Get<List<Company>>(requestUri).Result.SingleOrDefault();

            return companies;
        }

        public List<Company> SearchCompaniesByName(string name)
        {
            string requestUri = string.Format("/companies/?search={0}&fields=*", name);
            var companies = _apiClient.Get<List<Company>>(requestUri).Result;

            return companies;
        }

        public Credit GetCreditById(int id)
        {
            string requestUri = string.Format("/credits/{0}?fields=*", id);
            var credit = _apiClient.Get<List<Credit>>(requestUri).Result.SingleOrDefault();

            return credit;
        }

        public List<Credit> SearchCreditsByName(string name)
        {
            string requestUri = string.Format("/credits/?search={0}&fields=*", name);
            var credits = _apiClient.Get<List<Credit>>(requestUri).Result;

            return credits;
        }

        public Feed GetFeedById(int id)
        {
            string requestUri = string.Format("/feeds/{0}?fields=*", id);
            var feeds = _apiClient.Get<List<Feed>>(requestUri).Result.SingleOrDefault();

            return feeds;
        }

        public List<Feed> SearchFeedsByName(string name)
        {
            string requestUri = string.Format("/feeds/?search={0}&fields=*", name);
            var feeds = _apiClient.Get<List<Feed>>(requestUri).Result;

            return feeds;
        }

        public Franchise GetFranchiseById(int id)
        {
            string requestUri = string.Format("/franchises/{0}?fields=*", id);
            var franchises = _apiClient.Get<List<Franchise>>(requestUri).Result.SingleOrDefault();

            return franchises;
        }

        public List<Franchise> SearchFranchisesByName(string name)
        {
            string requestUri = string.Format("/franchises/?search={0}&fields=*", name);
            var franchises = _apiClient.Get<List<Franchise>>(requestUri).Result;

            return franchises;
        }

        public GameCollection GetGameCollectionById(int id)
        {
            string requestUri = string.Format("/collections/{0}?fields=*", id);
            var gameCollection = _apiClient.Get<List<GameCollection>>(requestUri).Result.SingleOrDefault();

            return gameCollection;
        }

        public List<GameCollection> SearchGameCollectionsByName(string name)
        {
            string requestUri = string.Format("/collections/?search={0}&fields=*", name);
            var gameCollections = _apiClient.Get<List<GameCollection>>(requestUri).Result;

            return gameCollections;
        }

        public GameVersion GetGameVersionById(int id)
        {
            string requestUri = string.Format("/game_versions/{0}?fields=*", id);
            var gameVersion = _apiClient.Get<List<GameVersion>>(requestUri).Result.SingleOrDefault();

            return gameVersion;
        }

        public List<GameVersion> SearchGameVersionsByName(string name)
        {
            string requestUri = string.Format("/game_versions/?search={0}&fields=*", name);
            var gameVersions = _apiClient.Get<List<GameVersion>>(requestUri).Result;

            return gameVersions;
        }

        public Genre GetGenreById(int id)
        {
            string requestUri = string.Format("/genres/{0}?fields=*", id);
            var genre = _apiClient.Get<List<Genre>>(requestUri).Result.SingleOrDefault();

            return genre;
        }

        public List<Genre> SearchGenresByName(string name)
        {
            string requestUri = string.Format("/genres/?search={0}&fields=*", name);
            var genres = _apiClient.Get<List<Genre>>(requestUri).Result;

            return genres;
        }

        public Keyword GetKeywordById(int id)
        {
            string requestUri = string.Format("/games/{0}?fields=*", id);
            var keyword = _apiClient.Get<List<Keyword>>(requestUri).Result.SingleOrDefault();

            return keyword;
        }

        public List<Keyword> SearchKeywordsByName(string name)
        {
            string requestUri = string.Format("/games/?search={0}&fields=*", name);
            var keywords = _apiClient.Get<List<Keyword>>(requestUri).Result;

            return keywords;
        }

        public Pulse GetPulseById(int id)
        {
            string requestUri = string.Format("/pulses/{0}?fields=*", id);
            var pulse = _apiClient.Get<List<Pulse>>(requestUri).Result.SingleOrDefault();

            return pulse;
        }

        public List<Pulse> SearchPulsesByName(string name)
        {
            string requestUri = string.Format("/pulses/?search={0}&fields=*", name);
            var pulses = _apiClient.Get<List<Pulse>>(requestUri).Result;

            return pulses;
        }

        public PulseGroup GetPulseGroupById(int id)
        {
            string requestUri = string.Format("/pulse_groups/{0}?fields=*", id);
            var pulseGroup = _apiClient.Get<List<PulseGroup>>(requestUri).Result.SingleOrDefault();

            return pulseGroup;
        }

        public List<PulseGroup> SearchPulseGroupsByName(string name)
        {
            string requestUri = string.Format("/pulse_groups/?search={0}&fields=*", name);
            var pulseGroups = _apiClient.Get<List<PulseGroup>>(requestUri).Result;

            return pulseGroups;
        }

        public PulseSource GetPulseSourceById(int id)
        {
            string requestUri = string.Format("/pulse_sources/{0}?fields=*", id);
            var pulseSource = _apiClient.Get<List<PulseSource>>(requestUri).Result.SingleOrDefault();

            return pulseSource;
        }

        public List<PulseSource> SearchPulseSourcesByName(string name)
        {
            string requestUri = string.Format("/pulse_sources/?search={0}&fields=*", name);
            var pulseSources = _apiClient.Get<List<PulseSource>>(requestUri).Result;

            return pulseSources;
        }

        public Page GetPageById(int id)
        {
            string requestUri = string.Format("/pages/{0}?fields=*", id);
            var page = _apiClient.Get<List<Page>>(requestUri).Result.SingleOrDefault();

            return page;
        }

        public List<Page> SearchPagesByName(string name)
        {
            string requestUri = string.Format("/pages/?search={0}&fields=*", name);
            var pages = _apiClient.Get<List<Page>>(requestUri).Result;

            return pages;
        }

        public Person GetPersonById(int id)
        {
            string requestUri = string.Format("/people/{0}?fields=*", id);
            var person = _apiClient.Get<List<Person>>(requestUri).Result.SingleOrDefault();

            return person;
        }

        public List<Person> SearchPersonsByName(string name)
        {
            string requestUri = string.Format("/people/?search={0}&fields=*", name);
            var persons = _apiClient.Get<List<Person>>(requestUri).Result;

            return persons;
        }

        public Platform GetPlatformById(int id)
        {
            string requestUri = string.Format("/platforms/{0}?fields=*", id);
            var platform = _apiClient.Get<List<Platform>>(requestUri).Result.SingleOrDefault();

            return platform;
        }

        public List<Platform> SearchPlatformsByName(string name)
        {
            string requestUri = string.Format("/platforms/?search={0}&fields=*", name);
            var platforms = _apiClient.Get<List<Platform>>(requestUri).Result;

            return platforms;
        }

        public PlayerPerspective GetPlayerPerspectiveById(int id)
        {
            string requestUri = string.Format("/player_perspectives/{0}?fields=*", id);
            var playerPerspective = _apiClient.Get<List<PlayerPerspective>>(requestUri).Result.SingleOrDefault();

            return playerPerspective;
        }

        public List<PlayerPerspective> SearchPlayerPerspectivesByName(string name)
        {
            string requestUri = string.Format("/player_perspectives/?search={0}&fields=*", name);
            var playerPerspectives = _apiClient.Get<List<PlayerPerspective>>(requestUri).Result;

            return playerPerspectives;
        }

        public PlayTime GetPlayTimeById(int id)
        {
            string requestUri = string.Format("/play_times/{0}?fields=*", id);
            var playTime = _apiClient.Get<List<PlayTime>>(requestUri).Result.SingleOrDefault();

            return playTime;
        }

        public List<PlayTime> SearchPlayTimesByName(string name)
        {
            string requestUri = string.Format("/play_times/?search={0}&fields=*", name);
            var playTimes = _apiClient.Get<List<PlayTime>>(requestUri).Result;

            return playTimes;
        }

        public GameReleaseDate GetReleaseDateById(int id)
        {
            string requestUri = string.Format("/release_dates/{0}?fields=*", id);
            var releaseDate = _apiClient.Get<List<GameReleaseDate>>(requestUri).Result.SingleOrDefault();

            return releaseDate;
        }

        public List<GameReleaseDate> SearchReleaseDatesByName(string name)
        {
            string requestUri = string.Format("/release_dates/?search={0}&fields=*", name);
            var realeaseDates = _apiClient.Get<List<GameReleaseDate>>(requestUri).Result;

            return realeaseDates;
        }

        public Review GetReviewById(int id)
        {
            string requestUri = string.Format("/reviews/{0}?fields=*", id);
            var review = _apiClient.Get<List<Review>>(requestUri).Result.SingleOrDefault();

            return review;
        }

        public List<Review> SearchReviewsByName(string name)
        {
            string requestUri = string.Format("/reviews/?search={0}&fields=*", name);
            var reviews = _apiClient.Get<List<Review>>(requestUri).Result;

            return reviews;
        }

        public Theme GetThemeById(int id)
        {
            string requestUri = string.Format("/themes/{0}?fields=*", id);
            var theme = _apiClient.Get<List<Theme>>(requestUri).Result.SingleOrDefault();

            return theme;
        }

        public List<Theme> SearchThemesByName(string name)
        {
            string requestUri = string.Format("/themes/?search={0}&fields=*", name);
            var themes = _apiClient.Get<List<Theme>>(requestUri).Result;

            return themes;
        }

        public Title GetTitleById(int id)
        {
            string requestUri = string.Format("/titles/{0}?fields=*", id);
            var title = _apiClient.Get<List<Title>>(requestUri).Result.SingleOrDefault();

            return title;
        }

        public List<Title> SearchTitlesByName(string name)
        {
            string requestUri = string.Format("/titles/?search={0}&fields=*", name);
            var titles = _apiClient.Get<List<Title>>(requestUri).Result;

            return titles;
        }

        public UserProfile GetUserProfileById(int id)
        {
            string requestUri = string.Format("/me/{0}?fields=*", id);
            var userProfile = _apiClient.Get<List<UserProfile>>(requestUri).Result.SingleOrDefault();

            return userProfile;
        }

        public List<UserProfile> SearchUserProfilesByName(string name)
        {
            string requestUri = string.Format("/me/?search={0}&fields=*", name);
            var userProfiles = _apiClient.Get<List<UserProfile>>(requestUri).Result;

            return userProfiles;
        }
    }
}
