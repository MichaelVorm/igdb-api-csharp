using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace IgdbApi.Dto
{
    public partial class PulseGroup : Game
    {
        [JsonProperty("published_at")]
        public long PublishedAt { get; set; }

        [JsonProperty("game")]
        public long Game { get; set; }

        [JsonProperty("pulses")]
        public long[] Pulses { get; set; }
    }
}