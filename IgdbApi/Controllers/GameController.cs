using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IgdbApi.Dto;
using IgdbApi.Interfaces;
using IgdbApi.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace IgdbApi.Controllers
{
    [Route("api/[controller]")]
    public class GameController : Controller
    {
        private IGameService _gameService { get; }

        public GameController(IGameService gameService)
        {
            _gameService = gameService;
        }
        // GET api/<controller>/5
        
        [HttpGet("{id}")]
        public Game GetGameById(int id)
        {
           var game = _gameService.GetGameById(id);

           return game;
        }

        // GET api/<controller>/5
        [Route("search/{name}")]
        [HttpGet]
        public List<Game> SearchGamesByName(string name)
        {
            var game = _gameService.SearchGamesByName(name);

            return game;
        }

        [Route("engine/{id}")]
        [HttpGet]
        public GameEngine GetGameEngineById(int id)
        {
            var gameEngine = _gameService.GetGameEngineById(id);

            return gameEngine;
        }

        // GET api/<controller>/5
        [Route("engine/search/{name}")]
        [HttpGet]
        public List<GameEngine> SearchGameEnginesByName(string name)
        {
            var gameEngines = _gameService.SearchGameEnginesByName(name);

            return gameEngines;
        }

        [Route("mode/{id}")]
        [HttpGet]
        public GameMode GetGameModeById(int id)
        {
            var gameMode = _gameService.GetGameModeById(id);

            return gameMode;
        }

        // GET api/<controller>/5
        [Route("mode/search/{name}")]
        [HttpGet]
        public List<GameMode> SearchGameModesByName(string name)
        {
            var gameModes = _gameService.SearchGameModesByName(name);

            return gameModes;
        }

        [Route("character/{id}")]
        [HttpGet]
        public Character GetCharacterById(int id)
        {
            var character = _gameService.GetCharacterById(id);

            return character;
        }

        // GET api/<controller>/5
        [Route("character/search/{name}")]
        [HttpGet]
        public List<Character> SearchCharactersByName(string name)
        {
            var characters = _gameService.SearchCharactersByName(name);

            return characters;
        }

        [Route("company/{id}")]
        [HttpGet]
        public Company GetCompanyById(int id)
        {
            var company = _gameService.GetCompanyById(id);

            return company;
        }

        // GET api/<controller>/5
        [Route("company/search/{name}")]
        [HttpGet]
        public List<Company> SearchCompaniesByName(string name)
        {
            var companies = _gameService.SearchCompaniesByName(name);

            return companies;
        }

        [Route("credit/{id}")]
        [HttpGet]
        public Credit GetCreditById(int id)
        {
            var credit = _gameService.GetCreditById(id);

            return credit;
        }

        // GET api/<controller>/5
        [Route("credit/search/{name}")]
        [HttpGet]
        public List<Credit> SearchCreditsByName(string name)
        {
            var credits = _gameService.SearchCreditsByName(name);

            return credits;
        }

        [Route("feed/{id}")]
        [HttpGet]
        public Feed GetFeedById(int id)
        {
            var feed = _gameService.GetFeedById(id);

            return feed;
        }

        // GET api/<controller>/5
        [Route("feed/search/{name}")]
        [HttpGet]
        public List<Feed> SearchFeedsByName(string name)
        {
            var feeds = _gameService.SearchFeedsByName(name);

            return feeds;
        }

        [Route("franchise/{id}")]
        [HttpGet]
        public Franchise GetFranchiseById(int id)
        {
            var franchise = _gameService.GetFranchiseById(id);

            return franchise;
        }

        // GET api/<controller>/5
        [Route("franchise/search/{name}")]
        [HttpGet]
        public List<Franchise> SearchFranchisesByName(string name)
        {
            var franchises = _gameService.SearchFranchisesByName(name);

            return franchises;
        }

        [Route("collection/{id}")]
        [HttpGet]
        public GameCollection GetGameCollectionById(int id)
        {
            var gameCollection = _gameService.GetGameCollectionById(id);

            return gameCollection;
        }

        // GET api/<controller>/5
        [Route("collection/search/{name}")]
        [HttpGet]
        public List<GameCollection> SearchGameCollectionsByName(string name)
        {
            var gameCollections = _gameService.SearchGameCollectionsByName(name);

            return gameCollections;
        }

        [Route("version/{id}")]
        [HttpGet]
        public GameVersion GetVersionById(int id)
        {
            var gameVersion = _gameService.GetGameVersionById(id);

            return gameVersion;
        }

        // GET api/<controller>/5
        [Route("version/search/{name}")]
        [HttpGet]
        public List<GameVersion> SearchVersionsByName(string name)
        {
            var gameVersions = _gameService.SearchGameVersionsByName(name);

            return gameVersions;
        }

        [Route("genre/{id}")]
        [HttpGet]
        public Genre GetGenreById(int id)
        {
            var genre = _gameService.GetGenreById(id);

            return genre;
        }

        // GET api/<controller>/5
        [Route("genre/search/{name}")]
        [HttpGet]
        public List<Genre> SearchGenresByName(string name)
        {
            var genres = _gameService.SearchGenresByName(name);

            return genres;
        }

        [Route("keyword/{id}")]
        [HttpGet]
        public Keyword GetKeywordById(int id)
        {
            var keyword = _gameService.GetKeywordById(id);

            return keyword;
        }

        // GET api/<controller>/5
        [Route("keyword/search/{name}")]
        [HttpGet]
        public List<Keyword> SearchKeywordsByName(string name)
        {
            var keywords = _gameService.SearchKeywordsByName(name);

            return keywords;
        }

        [Route("pulse/{id}")]
        [HttpGet]
        public Pulse GetPulseById(int id)
        {
            var pulse = _gameService.GetPulseById(id);

            return pulse;
        }

        // GET api/<controller>/5
        [Route("pulse/search/{name}")]
        [HttpGet]
        public List<Pulse> SearchPulsesByName(string name)
        {
            var pulses = _gameService.SearchPulsesByName(name);

            return pulses;
        }

        [Route("pulsegroup/{id}")]
        [HttpGet]
        public PulseGroup GetPulseGroupById(int id)
        {
            var pulseGroup = _gameService.GetPulseGroupById(id);

            return pulseGroup;
        }

        // GET api/<controller>/5
        [Route("pulsegroup/search/{name}")]
        [HttpGet]
        public List<PulseGroup> SearchPulseGroupsByName(string name)
        {
            var pulseGroups = _gameService.SearchPulseGroupsByName(name);

            return pulseGroups;
        }

        [Route("pulsesource/{id}")]
        [HttpGet]
        public PulseSource GetPulseSourceById(int id)
        {
            var pulseSource = _gameService.GetPulseSourceById(id);

            return pulseSource;
        }

        // GET api/<controller>/5
        [Route("pulsesource/search/{name}")]
        [HttpGet]
        public List<PulseSource> SearchPulseSourcesByName(string name)
        {
            var pulseSources = _gameService.SearchPulseSourcesByName(name);

            return pulseSources;
        }

        [Route("page/{id}")]
        [HttpGet]
        public Page GetPageById(int id)
        {
            var page = _gameService.GetPageById(id);

            return page;
        }

        // GET api/<controller>/5
        [Route("page/search/{name}")]
        [HttpGet]
        public List<Page> SearchPagesByName(string name)
        {
            var pages = _gameService.SearchPagesByName(name);

            return pages;
        }

        [Route("person/{id}")]
        [HttpGet]
        public Person GetPersonById(int id)
        {
            var person = _gameService.GetPersonById(id);

            return person;
        }

        // GET api/<controller>/5
        [Route("person/search/{name}")]
        [HttpGet]
        public List<Person> SearchPersonsByName(string name)
        {
            var person = _gameService.SearchPersonsByName(name);

            return person;
        }

        [Route("platform/{id}")]
        [HttpGet]
        public Platform GetPlatformById(int id)
        {
            var game = _gameService.GetPlatformById(id);

            return game;
        }

        // GET api/<controller>/5
        [Route("platform/search/{name}")]
        [HttpGet]
        public List<Platform> SearchPlatformsByName(string name)
        {
            var platforms = _gameService.SearchPlatformsByName(name);

            return platforms;
        }

        [Route("playerperspective/{id}")]
        [HttpGet]
        public PlayerPerspective GetPlayerPerspectiveById(int id)
        {
            var game = _gameService.GetPlayerPerspectiveById(id);

            return game;
        }

        // GET api/<controller>/5
        [Route("playerperspective/search/{name}")]
        [HttpGet]
        public List<PlayerPerspective> SearchPlayerPerspectivesByName(string name)
        {
            var game = _gameService.SearchPlayerPerspectivesByName(name);

            return game;
        }

        [Route("playtime/{id}")]
        [HttpGet]
        public PlayTime GetPlayTimeById(int id)
        {
            var playTime = _gameService.GetPlayTimeById(id);

            return playTime;
        }

        // GET api/<controller>/5
        [Route("playtime/search/{name}")]
        [HttpGet]
        public List<PlayTime> SearchPlayTimesByName(string name)
        {
            var playTimes = _gameService.SearchPlayTimesByName(name);

            return playTimes;
        }

        [Route("releasedate/{id}")]
        [HttpGet]
        public GameReleaseDate GetReleaseDateById(int id)
        {
            var releaseDate = _gameService.GetReleaseDateById(id);

            return releaseDate;
        }

        // GET api/<controller>/5
        [Route("releasedate/search/{name}")]
        [HttpGet]
        public List<GameReleaseDate> SearchReleaseDatesByName(string name)
        {
            var releaseDates = _gameService.SearchReleaseDatesByName(name);

            return releaseDates;
        }

        [Route("review/{id}")]
        [HttpGet]
        public Review GetReviewById(int id)
        {
            var review = _gameService.GetReviewById(id);

            return review;
        }

        // GET api/<controller>/5
        [Route("review/search/{name}")]
        [HttpGet]
        public List<Review> SearchReviewsByName(string name)
        {
            var reviews = _gameService.SearchReviewsByName(name);

            return reviews;
        }

        [Route("theme/{id}")]
        [HttpGet]
        public Theme GetThemeById(int id)
        {
            var theme = _gameService.GetThemeById(id);

            return theme;
        }

        // GET api/<controller>/5
        [Route("theme/search/{name}")]
        [HttpGet]
        public List<Theme> SearchThemesByName(string name)
        {
            var themes = _gameService.SearchThemesByName(name);

            return themes;
        }

        [Route("title/{id}")]
        [HttpGet]
        public Title GetTitleById(int id)
        {
            var title = _gameService.GetTitleById(id);

            return title;
        }

        // GET api/<controller>/5
        [Route("title/search/{name}")]
        [HttpGet]
        public List<Title> SearchTitlesByName(string name)
        {
            var titles = _gameService.SearchTitlesByName(name);

            return titles;
        }

        [Route("userprofile/{id}")]
        [HttpGet]
        public UserProfile GetUserProfileById(int id)
        {
            var userProfile = _gameService.GetUserProfileById(id);

            return userProfile;
        }

        // GET api/<controller>/5
        [Route("userprofile/search/{name}")]
        [HttpGet]
        public List<UserProfile> SearchUserProfilesByName(string name)
        {
            var userProfiles = _gameService.SearchUserProfilesByName(name);

            return userProfiles;
        }
    }
}
