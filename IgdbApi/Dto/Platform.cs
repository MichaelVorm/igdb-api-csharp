﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace IgdbApi.Dto
{
    public class Platform : Game
    {
        [JsonProperty("versions")]
        public Version[] Versions { get; set; }
    }

    public class Version
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
}