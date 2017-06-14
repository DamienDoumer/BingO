using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace BingO.TrendingTopicsNewsSearchResults
{
    [Serializable]
    public class Image
    {
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }
        [JsonProperty(PropertyName = "provider")]
        public List<Provider> Providers { get; set; }
    }
}
