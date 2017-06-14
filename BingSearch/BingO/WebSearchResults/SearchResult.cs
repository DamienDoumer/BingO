using Newtonsoft.Json;
using System;

namespace BingOWebSearchResults
{
    [Serializable]
    public class SearchResult
    {
        /// <summary>
        /// For Exception Handling
        /// </summary>
        [JsonProperty(PropertyName = "statusCode")]
        public int StatusCode { get; set; }
        /// <summary>
        /// For Exception Handling
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }


        [JsonProperty(PropertyName = "_type")]
        public string Type { get; set; }
        [JsonProperty(PropertyName = "webPages")]
        public WebPages WebPages { get; set; }
        [JsonProperty(PropertyName = "images")]
        public Images Images { get; set; }
        [JsonProperty(PropertyName = "news")]
        public News News { get; set; }
        [JsonProperty(PropertyName = "relatedSearches")]
        public RelatedSearches RelatedSearches { get; set; }
        [JsonProperty(PropertyName = "videos")]
        public Videos Videos { get; set; }
        [JsonProperty(PropertyName = "rankingResponse")]
        public RankingResponse RankingResponse { get; set; }
    }
}
