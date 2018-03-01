using IgdbApi.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IgdbApi.Interfaces
{
    public interface IPulseGroupService
    {

        PulseGroup GetPulseGroupById(int id);
        List<PulseGroup> SearchPulseGroupsByName(string name);
    }
}
