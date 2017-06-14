using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace BingOWebSearchResults
{
    [Serializable]
    public class Images
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        [JsonProperty(PropertyName = "readLink")]
        public string ReadLink { get; set; }
        [JsonProperty(PropertyName = "webSearchUrl")]
        public string WebSearchUrl { get; set; }
        [JsonProperty(PropertyName = "isFamilyFriendly")]
        public bool IsFamilyFriendly { get; set; }
        [JsonProperty(PropertyName = "value")]
        public List<ImageResult> ImageResults { get; set; }
        [JsonProperty(PropertyName = "displayShoppingSourcesBadges")]
        public bool DisplayShoppingSourcesBadges { get; set; }
        [JsonProperty(PropertyName = "displayRecipeSourcesBadges")]
        public bool DisplayRecipeSourcesBadges { get; set; }
    }
}
