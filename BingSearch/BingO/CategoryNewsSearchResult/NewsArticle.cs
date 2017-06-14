using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace BingO.CategoryNewsSearchResult
{
    [Serializable]
    public class NewsArticle
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }
        [JsonProperty(PropertyName = "image")]
        public Image Image { get; set; }
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        [JsonProperty(PropertyName = "about")]
        public List<About> About { get; set; }
        [JsonProperty(PropertyName = "provider")]
        public List<Provider> Provider { get; set; }
        [JsonProperty(PropertyName = "datePublished")]
        public string DatePublished { get; set; }
        [JsonProperty(PropertyName = "category")]
        public string Category { get; set; }
        [JsonProperty(PropertyName = "clusteredArticles")]
        public List<ClusteredArticle> ClusteredArticles { get; set; }
        [JsonProperty(PropertyName = "mentions")]
        public List<Mention2> Mentions { get; set; }
    }
}
