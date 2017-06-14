using Newtonsoft.Json;

namespace BingO.GlobalNewsResults
{
    public class Thumbnail2
    {
        [JsonProperty(PropertyName = "width")]
        public int Width { get; set; }
        [JsonProperty(PropertyName = "height")]
        public int Height { get; set; }
    }
}
