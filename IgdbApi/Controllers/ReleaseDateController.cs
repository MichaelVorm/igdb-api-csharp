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
    public class ReleaseDateController : Controller
    {
        private IReleaseDateService _releaseDateService { get; }

        public ReleaseDateController(IReleaseDateService releaseDateService)
        {
            _releaseDateService = releaseDateService;
        }
        // GET api/<controller>/5
        
        [HttpGet("{id}")]
        public ReleaseDate GetReleaseDateById(int id)
        {
           var releaseDate = _releaseDateService.GetReleaseDateById(id);

           return releaseDate;
        }

        // GET api/<controller>/5
        [Route("search/{name}")]
        [HttpGet]
        public List<ReleaseDate> SearchReleaseDatesByName(string name)
        {
            var releaseDates = _releaseDateService.SearchReleaseDatesByName(name);

            return releaseDates;
        }
    }
}
