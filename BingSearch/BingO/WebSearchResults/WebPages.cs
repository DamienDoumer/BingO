using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace BingOWebSearchResults
{
    [Serializable]
    public class WebSearchResult
    {
        [JsonProperty(PropertyName = "webSearchUrl")]
        public string WebSearchUrl { get; set; }
        public int totalEstimatedMatches { get; set; }
        [JsonProperty(PropertyName = "value")]
        public List<WepPageResult> WebPages { get; set; }
    }
}
