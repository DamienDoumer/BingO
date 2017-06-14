using Newtonsoft.Json;

namespace BingO.NewsSearchResult
{
    public class Mention2
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
    }
}
