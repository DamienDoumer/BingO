using Newtonsoft.Json;
using System;

namespace BingO.CategoryNewsSearchResult
{
    [Serializable]
    public class Mention
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
    }
}
