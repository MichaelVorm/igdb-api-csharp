﻿using Newtonsoft.Json;
using System.Collections.Generic;

namespace IgdbApi.Dto
{
    public partial class Feed : Game
    {
        [JsonProperty("pulse")]
        public long Pulse { get; set; }

        [JsonProperty("meta")]
        public string Meta { get; set; }
    }
}
