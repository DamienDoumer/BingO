using Newtonsoft.Json;

namespace BingO.NewsSearchResult
{
    public class About
    {
        [JsonProperty(PropertyName = "readLink")]
        public string ReadLink { get; set; }
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
    }
}
