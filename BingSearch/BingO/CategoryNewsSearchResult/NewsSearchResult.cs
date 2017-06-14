using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace BingO.CategoryNewsSearchResult
{
    [Serializable]
    class NewsSearchResult
    {
        [JsonProperty(PropertyName = "_type")]
        public string Type { get; set; }
        [JsonProperty(PropertyName = "value")]
        public List<NewsArticle> NewsArticles { get; set; }
    }
}
