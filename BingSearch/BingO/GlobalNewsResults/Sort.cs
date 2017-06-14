using Newtonsoft.Json;

namespace BingO.GlobalNewsResults
{
    public class Sort
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        [JsonProperty(PropertyName = "isSelected")]
        public bool IsSelected { get; set; }
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }
    }
}
