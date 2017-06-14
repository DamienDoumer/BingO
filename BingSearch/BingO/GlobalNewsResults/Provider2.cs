using Newtonsoft.Json;

namespace BingO.GlobalNewsResults
{
    public class Provider2
    {
        [JsonProperty(PropertyName = "_type")]
        public string Type { get; set; }
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
    }
}
