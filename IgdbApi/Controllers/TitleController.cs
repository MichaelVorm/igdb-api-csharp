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
    public class TitleController : Controller
    {
        private ITitleService _titleService { get; }

        public TitleController(ITitleService titleService)
        {
            _titleService = titleService;
        }
        // GET api/<controller>/5
        
        [HttpGet("{id}")]
        public Title GetTitleById(int id)
        {
           var title = _titleService.GetTitleById(id);

           return title;
        }

        // GET api/<controller>/5
        [Route("search/{name}")]
        [HttpGet]
        public List<Title> SearchTitlesByName(string name)
        {
            var titles = _titleService.SearchTitlesByName(name);

            return titles;
        }
    }
}
