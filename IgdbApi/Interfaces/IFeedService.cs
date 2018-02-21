using IgdbApi.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IgdbApi.Interfaces
{
    public interface IFeedService
    {
        Feed GetFeedById(int id);
        List<Feed> SearchFeedsByName(string name);
    }
}
