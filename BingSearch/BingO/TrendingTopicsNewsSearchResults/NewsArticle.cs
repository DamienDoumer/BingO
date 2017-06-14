using Newtonsoft.Json;
using System;

namespace BingO.TrendingTopicsNewsSearchResults
{
    [Serializable]
    public class NewsArticle
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        [JsonProperty(PropertyName = "image")]
        public Image Image { get; set; }
        [JsonProperty(PropertyName = "webSearchUrl")]
        public string WebSearchUrl { get; set; }
        [JsonProperty(PropertyName = "isBreakingNews")]
        public bool IsBreakingNews { get; set; }
        [JsonProperty(PropertyName = "query")]
        public Query Query { get; set; }
    }
}
