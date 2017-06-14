using Newtonsoft.Json;
using System;

namespace BingOWebSearchResults
{
    [Serializable]
    public class ImageResult
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        [JsonProperty(PropertyName = "webSearchUrl")]
        public string WebSearchUrl { get; set; }
        [JsonProperty(PropertyName = "thumbnailUrl")]
        public string ThumbnailUrl { get; set; }

        [JsonProperty(PropertyName = "datePublished")]
        public string DatePublished { get; set; }

        [JsonProperty(PropertyName = "contentUrl")]
        public string ContentUrl { get; set; }

        [JsonProperty(PropertyName = "hostPageUrl")]
        public string HostPageUrl { get; set; }
        [JsonProperty(PropertyName = "contentSize")]
        public string ContentSize { get; set; }
        [JsonProperty(PropertyName = "encodingFormat")]

        public string EncodingFormat { get; set; }
        [JsonProperty(PropertyName = "hostPageDisplayUrl")]

        public string HostPageDisplayUrl { get; set; }
        [JsonProperty(PropertyName = "width")]

        public int Width { get; set; }
        [JsonProperty(PropertyName = "height")]

        public int Height { get; set; }
        [JsonProperty(PropertyName = "thumbnail")]

        public Thumbnail Thumbnail { get; set; }
    }
}
