using Newtonsoft.Json;
using System;

namespace BingO.CategoryNewsSearchResult
{
    [Serializable]
    public class Mention2
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
    }
}
