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
    public class PulseGroupController : Controller
    {
        private IPulseGroupService _pulseGroupService { get; }

        public PulseGroupController(IPulseGroupService pulseGroupService)
        {
            _pulseGroupService = pulseGroupService;
        }
        // GET api/<controller>/5
        
        [HttpGet("{id}")]
        public PulseGroup GetPulseGroupById(int id)
        {
           var pulseGroup = _pulseGroupService.GetPulseGroupById(id);

           return pulseGroup;
        }

        // GET api/<controller>/5
        [Route("search/{name}")]
        [HttpGet]
        public List<PulseGroup> SearchPulseGroupsByName(string name)
        {
            var pulseGroups = _pulseGroupService.SearchPulseGroupsByName(name);

            return pulseGroups;
        }
    }
}
