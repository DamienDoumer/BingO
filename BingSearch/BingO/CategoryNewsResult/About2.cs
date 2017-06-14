using Newtonsoft.Json;
using System;

namespace BingO.CategoryNewsResult
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
