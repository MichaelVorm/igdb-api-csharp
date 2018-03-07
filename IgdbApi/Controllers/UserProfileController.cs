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
    public class UserProfileController : Controller
    {
        private IUserProfileService _userProfileService { get; }

        public UserProfileController(IUserProfileService userProfileService)
        {
            _userProfileService = userProfileService;
        }
        // GET api/<controller>/5
        
        [HttpGet("{id}")]
        public UserProfile GetUserProfileById(int id)
        {
           var userProfile = _userProfileService.GetUserProfileById(id);

           return userProfile;
        }

        // GET api/<controller>/5
        [Route("search/{name}")]
        [HttpGet]
        public List<UserProfile> SearchUserProfilesByName(string name)
        {
            var userProfiles = _userProfileService.SearchUserProfilesByName(name);

            return userProfiles;
        }
    }
}
