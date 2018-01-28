using Newtonsoft.Json;
using System.Collections.Generic;

namespace IgdbApi.Dto
{
    public partial class Character : Game
    {
        [JsonProperty("people")]
        public List<long> People { get; set; }
    }
}
