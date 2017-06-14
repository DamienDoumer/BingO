using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingOResults
{
    [Serializable]
    public class About
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
    }
    [Serializable]
    public class DeepLink
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }
    }
    [Serializable]
    public class Thumbnail
    {
        [JsonProperty(PropertyName = "width")]
        public int Width { get; set; }
        [JsonProperty(PropertyName = "height")]
        public int Height { get; set; }
    }
    [Serializable]
    public class Thumbnail2
    {
        [JsonProperty(PropertyName = "contentUrl")]
        public string ContentUrl { get; set; }
        [JsonProperty(PropertyName = "width")]
        public int Width { get; set; }
        [JsonProperty(PropertyName = "height")]
        public int Height { get; set; }
    }
    [Serializable]
    public class Image
    {
        [JsonProperty(PropertyName = "contentUrl")]
        public string ContentUrl { get; set; }
        [JsonProperty(PropertyName = "thumbnailUrl")]
        public string ThumbnailUrl { get; set; }
    }
    [Serializable]
    public class About2
    {
        [JsonProperty(PropertyName = "readLink")]
        public string ReadLink { get; set; }
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
    }
    [Serializable]
    public class Provider
    {
        [JsonProperty(PropertyName = "_type")]
        public string Type { get; set; }
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
    }
    [Serializable]
    public class Thumbnail3
    {
        [JsonProperty(PropertyName = "width")]
        public int Width { get; set; }
        [JsonProperty(PropertyName = "height")]
        public int Height { get; set; }
    }
    [Serializable]
    public class RelatedSearchResult
    {
        [JsonProperty(PropertyName = "text")]
        public string Text { get; set; }
        [JsonProperty(PropertyName = "displayText")]
        public string DisplayText { get; set; }
        [JsonProperty(PropertyName = "webSearchUrl")]
        public string WebSearchUrl { get; set; }
    }
    [Serializable]
    public class RelatedSearches
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        [JsonProperty(PropertyName = "value")]
        public List<RelatedSearchResult> Value { get; set; }
    }
    [Serializable]
    public class Publisher
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
    }
    [Serializable]
    public class Thumbnail4
    {
        [JsonProperty(PropertyName = "width")]
        public int Width { get; set; }
        [JsonProperty(PropertyName = "height")]
        public int Height { get; set; }
    }
    [Serializable]
    public class Value6
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
    }
    [Serializable]
    public class Item
    {
        [JsonProperty(PropertyName = "answerType")]
        public string AnswerType { get; set; }
        [JsonProperty(PropertyName = "value")]
        public Value6 Value { get; set; }
        [JsonProperty(PropertyName = "resultIndex")]

        public int? ResultIndex { get; set; }
    }
    [Serializable]
    public class Mainline
    {
        [JsonProperty(PropertyName = "items")]
        public List<Item> Items { get; set; }
    }
    [Serializable]
    public class Value7
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
    }
    [Serializable]
    public class Item2
    {
        [JsonProperty(PropertyName = "answerType")]
        public string AnswerType { get; set; }
        [JsonProperty(PropertyName = "value")]
        public Value7 Value { get; set; }
    }
    [Serializable]
    public class Sidebar
    {
        [JsonProperty(PropertyName = "items")]
        public List<Item2> Items { get; set; }
    }
    [Serializable]
    public class RankingResponse
    {
        [JsonProperty(PropertyName = "mainline")]
        public Mainline Mainline { get; set; }
        [JsonProperty(PropertyName = "sidebar")]
        public Sidebar Sidebar { get; set; }
    }
}
