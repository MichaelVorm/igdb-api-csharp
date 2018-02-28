using IgdbApi.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IgdbApi.Interfaces
{
    public interface IPageService
    {
        Page GetPageById(int id);
        List<Page> SearchPagesByName(string name);
    }
}
