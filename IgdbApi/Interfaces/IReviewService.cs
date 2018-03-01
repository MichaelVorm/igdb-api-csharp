using IgdbApi.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IgdbApi.Interfaces
{
    public interface IReviewService
    {
        Review GetReviewById(int id);
        List<Review> SearchReviewsByName(string name);
    }
}
