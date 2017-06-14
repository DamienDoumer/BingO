using Newtonsoft.Json;
using System;

namespace BingO.CategoryNewsResult
{
    [Serializable]
    public class Thumbnail
    {
        [JsonProperty(PropertyName = "contentUrl")]
        public string ContentUrl { get; set; }
        [JsonProperty(PropertyName = "width")]
        public int Width { get; set; }
        [JsonProperty(PropertyName = "height")]
        public int Height { get; set; }
    }
}
