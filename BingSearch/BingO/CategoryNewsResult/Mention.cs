using Newtonsoft.Json;
using System;

namespace BingO.CategoryNewsResult
{
    [Serializable]
    public class Mention
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
    }
}
