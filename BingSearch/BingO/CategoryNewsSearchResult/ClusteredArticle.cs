using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace BingO.CategoryNewsSearchResult
{
    [Serializable]
    public class ClusteredArticle
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        [JsonProperty(PropertyName = "about")]
        public List<About2> Abouts { get; set; }
        [JsonProperty(PropertyName = "provider")]
        public List<Provider2> Providers { get; set; }
        [JsonProperty(PropertyName = "datePublished")]
        public string DatePublished { get; set; }
        [JsonProperty(PropertyName = "category")]
        public string Category { get; set; }
        [JsonProperty(PropertyName = "Mentions")]
        public List<Mention> Mentions { get; set; }
    }
}
