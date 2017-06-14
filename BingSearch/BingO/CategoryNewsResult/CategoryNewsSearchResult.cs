using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace BingO.CategoryNewsResult
{
    [Serializable]
    public class CategoryNewsSearchResult
    {
        [JsonProperty(PropertyName = "_type")]
        public string Type { get; set; }
        [JsonProperty(PropertyName = "value")]
        public List<NewsArticle> NewsArticles { get; set; }
    }
}
