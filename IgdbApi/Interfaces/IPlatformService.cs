using IgdbApi.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IgdbApi.Interfaces
{
    public interface IPlatformService
    {

        Platform GetPlatformById(int id);
        List<Platform> SearchPlatformsByName(string name);
    }
}
