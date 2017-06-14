using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace BingO.GlobalNewsResults
{
    public class GlobalNewsSearchResult
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
        [JsonProperty(PropertyName = "readLink")]
        public string ReadLink { get; set; }
        [JsonProperty(PropertyName = "totalEstimatedMatches")]
        public int TotalEstimatedMatches { get; set; }
        [JsonProperty(PropertyName = "sort")]
        public List<Sort> Sort { get; set; }
        [JsonProperty(PropertyName = "value")]
        public List<NewsArticle> NewsArticles { get; set; }
    }
}
