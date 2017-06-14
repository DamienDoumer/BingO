using Newtonsoft.Json;

namespace BingO.GlobalNewsResults
{
    public class Image
    {
        [JsonProperty(PropertyName = "thumbnail")]
        public Thumbnail Thumbnail { get; set; }
    }
}
