using Newtonsoft.Json;

namespace BingO.GlobalNewsResults
{
    public class Mention
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
    }
}
