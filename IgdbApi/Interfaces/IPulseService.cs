using IgdbApi.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IgdbApi.Interfaces
{
    public interface IPulseService
    {

        Pulse GetPulseById(int id);
        List<Pulse> SearchPulsesByName(string name);
    }
}
