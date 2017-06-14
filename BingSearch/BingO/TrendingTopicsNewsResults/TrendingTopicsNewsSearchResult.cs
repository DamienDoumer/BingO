﻿using Newtonsoft.Json;
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
        [JsonProperty(PropertyName = "value")]
        public List<NewsArticle> NewsArticles { get; set; }
    }
}
