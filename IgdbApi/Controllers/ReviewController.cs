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
    public class ReviewController : Controller
    {
        private IReviewService _reviewService { get; }

        public ReviewController(IReviewService reviewService)
        {
            _reviewService = reviewService;
        }
        // GET api/<controller>/5
        
        [HttpGet("{id}")]
        public Review GetReviewById(int id)
        {
           var review = _reviewService.GetReviewById(id);

           return review;
        }

        // GET api/<controller>/5
        [Route("search/{name}")]
        [HttpGet]
        public List<Review> SearchReviewsByName(string name)
        {
            var reviews = _reviewService.SearchReviewsByName(name);

            return reviews;
        }
    }
}
