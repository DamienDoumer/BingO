using Newtonsoft.Json;
using System;

namespace BingOWebSearchResults
{
    [Serializable]
    public class Video
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        [JsonProperty(PropertyName = "thumbnailUrl")]
        public string ThumbnailUrl { get; set; }
        [JsonProperty(PropertyName = "allowHttpsEmbed")]
        public bool AllowHttpsEmbed { get; set; }
        [JsonProperty(PropertyName = "thumbnail")]
        public Thumbnail3 thumbnail { get; set; }
    }
}
