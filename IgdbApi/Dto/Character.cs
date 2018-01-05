using Newtonsoft.Json;
using System.Collections.Generic;

namespace IgdbApi.Dto
{
    public partial class Character
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("created_at")]
        public long CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public long UpdatedAt { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("people")]
        public List<long> People { get; set; }

        [JsonProperty("games")]
        public List<long> Games { get; set; }
    }
}
