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
    public class PageController : Controller
    {
        private IPageService _pageService { get; }

        public PageController(IPageService pageService)
        {
            _pageService = pageService;
        }
        // GET api/<controller>/5
        
        [HttpGet("{id}")]
        public Page GetPageById(int id)
        {
           var page = _pageService.GetPageById(id);

           return page;
        }

        // GET api/<controller>/5
        [Route("search/{name}")]
        [HttpGet]
        public List<Page> SearchPagesByName(string name)
        {
            var pages = _pageService.SearchPagesByName(name);

            return pages;
        }
    }
}
