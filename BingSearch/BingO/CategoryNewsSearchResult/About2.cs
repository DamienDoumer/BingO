using Newtonsoft.Json;
using System;

namespace BingO.CategoryNewsSearchResult
{
    [Serializable]
    public class About2
    {
        [JsonProperty(PropertyName = "readLink")]
        public string ReadLink { get; set; }
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
    }
}
