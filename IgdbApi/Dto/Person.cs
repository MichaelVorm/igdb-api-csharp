using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace IgdbApi.Dto
{
    public class Person : Game
    {
        [JsonProperty("gender")]
        public long Gender { get; set; }
    }
}
