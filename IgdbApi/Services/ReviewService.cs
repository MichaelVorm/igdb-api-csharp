using IgdbApi.Dto;
using IgdbApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IgdbApi.Services
{
    public class ReviewService : IReviewService
    {
        private IApiClient _apiClient;

        public ReviewService(IApiClient apiClient)
        {
            _apiClient = apiClient;
        }

        public Review GetReviewById(int id)
        {
            string requestUri = string.Format("/reviews/{0}?fields=*", id);
            var review = _apiClient.Get<List<Review>>(requestUri).Result;

            return review[0];
        }

        public List<Review> SearchReviewsByName(string name)
        {
            string requestUri = string.Format("/reviews/?search={0}&fields=*", name);
            var reviews = _apiClient.Get<List<Review>>(requestUri).Result;

            return reviews;
        }
    }
}
