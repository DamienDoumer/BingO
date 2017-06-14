using Newtonsoft.Json;

namespace BingO.NewsSearchResult
{
    public class Image
    {
        [JsonProperty(PropertyName = "thumbnail")]
        public Thumbnail Thumbnail { get; set; }
    }
}
