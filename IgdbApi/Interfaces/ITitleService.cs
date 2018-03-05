using IgdbApi.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IgdbApi.Interfaces
{
    public interface ITitleService
    {
        Title GetTitleById(int id);
        List<Title> SearchTitlesByName(string name);
    }
}
