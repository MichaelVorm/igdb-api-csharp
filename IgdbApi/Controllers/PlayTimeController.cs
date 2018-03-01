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
    public class PlayTimeController : Controller
    {
        private IPlayTimeService _playTimeService { get; }

        public PlayTimeController(IPlayTimeService playTimeService)
        {
            _playTimeService = playTimeService;
        }
        // GET api/<controller>/5
        
        [HttpGet("{id}")]
        public PlayTime GetPlayTimeById(int id)
        {
           var playTime = _playTimeService.GetPlayTimeById(id);

           return playTime;
        }

        // GET api/<controller>/5
        [Route("search/{name}")]
        [HttpGet]
        public List<PlayTime> SearchPlayTimesByName(string name)
        {
            var playTimes = _playTimeService.SearchPlayTimesByName(name);

            return playTimes;
        }
    }
}
