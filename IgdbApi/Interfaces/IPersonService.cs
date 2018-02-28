using IgdbApi.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IgdbApi.Interfaces
{
    public interface IPersonService
    {

        Person GetPersonById(int id);
        List<Person> SearchPersonsByName(string name);
    }
}
