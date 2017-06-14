using Newtonsoft.Json;

namespace BingO.GlobalNewsResults
{
    public class Video
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        [JsonProperty(PropertyName = "thumbnailUrl")]
        public string thumbnailUrl { get; set; }
        [JsonProperty(PropertyName = "embedHtml")]
        public string embedHtml { get; set; }
        [JsonProperty(PropertyName = "allowHttpsEmbed")]
        public bool allowHttpsEmbed { get; set; }
        [JsonProperty(PropertyName = "thumbnail")]
        public Thumbnail2 thumbnail { get; set; }
    }
}
