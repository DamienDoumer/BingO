using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace BingOWebSearchResults
{
    [Serializable]
    public class News
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        [JsonProperty(PropertyName = "readLink")]
        public string ReadLink { get; set; }
        [JsonProperty(PropertyName = "value")]
        public List<NewsSearchResult> Value { get; set; }
    }
}
