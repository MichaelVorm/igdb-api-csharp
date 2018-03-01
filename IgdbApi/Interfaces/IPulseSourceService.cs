using IgdbApi.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IgdbApi.Interfaces
{
    public interface IPulseSourceService
    {

        PulseSource GetPulseSourceById(int id);
        List<PulseSource> SearchPulseSourcesByName(string name);
    }
}
