using Newtonsoft.Json;
using System;

namespace BingO.CategoryNewsResult
{
    [Serializable]
    public class Mention2
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
    }
}
