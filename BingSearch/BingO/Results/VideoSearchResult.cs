using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace BingOResults
{
    [Serializable]
    public class VideoSearchResult
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        public string description { get; set; }
        [JsonProperty(PropertyName = "webSearchUrl")]
        public string WebSearchUrl { get; set; }
        [JsonProperty(PropertyName = "thumbnailUrl")]
        public string ThumbnailUrl { get; set; }
        [JsonProperty(PropertyName = "datePublished")]
        public string DatePublished { get; set; }
        [JsonProperty(PropertyName = "publisher")]
        public List<Publisher> Publisher { get; set; }
        [JsonProperty(PropertyName = "contentUrl")]
        public string ContentUrl { get; set; }
        [JsonProperty(PropertyName = "hostPageUrl")]
        public string hostPageUrl { get; set; }
        [JsonProperty(PropertyName = "encodingFormat")]
        public string EncodingFormat { get; set; }
        [JsonProperty(PropertyName = "hostPageDisplayUrl")]
        public string HostPageDisplayUrl { get; set; }
        [JsonProperty(PropertyName = "width")]
        public int Width { get; set; }
        [JsonProperty(PropertyName = "height")]
        public int Height { get; set; }
        [JsonProperty(PropertyName = "duration")]
        public string Duration { get; set; }
        [JsonProperty(PropertyName = "motionThumbnailUrl")]
        public string MotionThumbnailUrl { get; set; }
        [JsonProperty(PropertyName = "embedHtml")]
        public string EmbedHtml { get; set; }
        [JsonProperty(PropertyName = "allowHttpsEmbed")]
        public bool AllowHttpsEmbed { get; set; }
        [JsonProperty(PropertyName = "viewCount")]
        public int ViewCount { get; set; }
        [JsonProperty(PropertyName = "thumbnail")]
        public Thumbnail4 Thumbnail { get; set; }
        [JsonProperty(PropertyName = "allowMobileEmbed")]
        public bool AllowMobileEmbed { get; set; }
        [JsonProperty(PropertyName = "isSuperfresh")]
        public bool IsSuperfresh { get; set; }
    }
}
