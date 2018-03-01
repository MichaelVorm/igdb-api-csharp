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
    public class PulseSourceController : Controller
    {
        private IPulseSourceService _pulseSourceService { get; }

        public PulseSourceController(IPulseSourceService pulseSourceService)
        {
            _pulseSourceService = pulseSourceService;
        }
        // GET api/<controller>/5
        
        [HttpGet("{id}")]
        public PulseSource GetPulseSourceById(int id)
        {
           var pulseSource = _pulseSourceService.GetPulseSourceById(id);

           return pulseSource;
        }

        // GET api/<controller>/5
        [Route("search/{name}")]
        [HttpGet]
        public List<PulseSource> SearchPulseSourcesByName(string name)
        {
            var pulseSources = _pulseSourceService.SearchPulseSourcesByName(name);

            return pulseSources;
        }
    }
}
