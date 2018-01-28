using Newtonsoft.Json;

namespace IgdbApi.Dto
{
    public class GameCollection
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

        [JsonProperty("games")]
        public long[] Games { get; set; }
    }
}
