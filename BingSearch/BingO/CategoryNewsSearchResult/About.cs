using Newtonsoft.Json;
using System;

namespace BingO.CategoryNewsSearchResult
{
    [Serializable]
    public class About
    {
        [JsonProperty(PropertyName = "readLink")]
        public string ReadLink { get; set; }
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
    }
}
