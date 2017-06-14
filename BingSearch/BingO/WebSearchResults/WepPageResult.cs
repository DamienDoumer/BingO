using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace BingOResults
{
    [Serializable]
    public class WepPageResult
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }
        public List<About> about { get; set; }
        [JsonProperty(PropertyName = "displayUrl")]
        public string DisplayUrl { get; set; }
        [JsonProperty(PropertyName = "snippet")]
        public string Snippet { get; set; }
        [JsonProperty(PropertyName = "deepLinks")]
        public List<DeepLink> DeepLinks { get; set; }
        [JsonProperty(PropertyName = "dateLastCrawled")]
        public string DateLastCrawled { get; set; }
    }
}
