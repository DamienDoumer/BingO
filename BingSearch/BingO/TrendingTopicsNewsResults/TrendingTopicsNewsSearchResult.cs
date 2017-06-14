using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingO.TrendingTopicsNewsResults
{
    [Serializable]
    public class TrendingTopicsNewsSearchResult
    {
        [JsonProperty(PropertyName = "_type")]
        public string Type { get; set; }
        [JsonProperty(PropertyName = "value")]
        public List<NewsArticle> NewsArticles { get; set; }
    }
}
