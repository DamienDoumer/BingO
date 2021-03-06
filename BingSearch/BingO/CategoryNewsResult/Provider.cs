﻿using Newtonsoft.Json;
using System;

namespace BingO.CategoryNewsResult
{
    [Serializable]
    public class Provider
    {
        [JsonProperty(PropertyName = "_type")]
        public string Type { get; set; }
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
    }
}
