using Newtonsoft.Json;

namespace BingO.NewsSearchResult
{
    public class Mention
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
    }
}
