using Newtonsoft.Json;
using System;

namespace BingO.CategoryNewsResult
{
    [Serializable]
    public class Image
    {
        [JsonProperty(PropertyName = "thumbnail")]
        public Thumbnail Thumbnail { get; set; }
    }
}
