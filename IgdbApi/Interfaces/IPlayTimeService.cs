using IgdbApi.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IgdbApi.Interfaces
{
    public interface IPlayTimeService
    {

        PlayTime GetPlayTimeById(int id);
        List<PlayTime> SearchPlayTimesByName(string name);
    }
}
