using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using IgdbApi.Services;
using IgdbApi.Dto;
using IgdbApi.Interfaces;

namespace IgdbApi.Controllers
{
    [Route("api/[controller]")]
    public class FeedController : Controller
    {
        private IFeedService _feedService { get; }

        public FeedController(IFeedService feedService)
        {
            _feedService = feedService;
        }
        // GET api/<controller>/5

        [HttpGet("{id}")]
        public Feed GetFeedById(int id)
        {
            var feed = _feedService.GetFeedById(id);

            return feed;
        }

        // GET api/<controller>/5
        [Route("search/{name}")]
        [HttpGet]
        public List<Feed> SearchFeedsByName(string name)
        {
            var feeds = _feedService.SearchFeedsByName(name);

            return feeds;
        }
    }
}