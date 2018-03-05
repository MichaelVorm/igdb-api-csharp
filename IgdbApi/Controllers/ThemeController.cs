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
    public class ThemeController : Controller
    {
        private IThemeService _themeService { get; }

        public ThemeController(IThemeService themeService)
        {
            _themeService = themeService;
        }
        // GET api/<controller>/5
        
        [HttpGet("{id}")]
        public Theme GetThemeById(int id)
        {
           var theme = _themeService.GetThemeById(id);

           return theme;
        }

        // GET api/<controller>/5
        [Route("search/{name}")]
        [HttpGet]
        public List<Theme> SearchThemesByName(string name)
        {
            var themes = _themeService.SearchThemesByName(name);

            return themes;
        }
    }
}
