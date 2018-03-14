using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace IgdbApi.Dto
{
    public class GameReleaseDate : Game
    {
        [JsonProperty("game")]
        public long Game { get; set; }
    }
}