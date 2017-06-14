using Newtonsoft.Json;
using System;

namespace BingO.TrendingTopicsNewsSearchResults
{
    [Serializable]
    public class Query
    {
        [JsonProperty(PropertyName = "text")]
        public string Text { get; set; }
    }
}
