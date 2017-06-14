using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace BingO.GlobalNewsResults
{
    public class GlobalNewsSearchResult
    {
        /// <summary>
        /// For Exception Handling
        /// </summary>
        [JsonProperty(PropertyName = "statusCode")]
        public int StatusCode { get; set; }
        /// <summary>
        /// For Exception Handling
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }
        [JsonProperty(PropertyName = "_type")]
        public string Type { get; set; }
        [JsonProperty(PropertyName = "readLink")]
        public string ReadLink { get; set; }
        [JsonProperty(PropertyName = "totalEstimatedMatches")]
        public int TotalEstimatedMatches { get; set; }
        [JsonProperty(PropertyName = "sort")]
        public List<Sort> Sort { get; set; }
        [JsonProperty(PropertyName = "value")]
        public List<NewsArticle> NewsArticles { get; set; }
    }

    public class Sort
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        [JsonProperty(PropertyName = "isSelected")]
        public bool IsSelected { get; set; }
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }
    }

    public class Thumbnail
    {
        [JsonProperty(PropertyName = "contentUrl")]
        public string ContentUrl { get; set; }
        [JsonProperty(PropertyName = "width")]
        public int Width { get; set; }
        [JsonProperty(PropertyName = "height")]
        public int Height { get; set; }
    }

    public class Image
    {
        [JsonProperty(PropertyName = "thumbnail")]
        public Thumbnail Thumbnail { get; set; }
    }

    public class About
    {
        [JsonProperty(PropertyName = "readLink")]
        public string ReadLink { get; set; }
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
    }

    public class Provider
    {
        [JsonProperty(PropertyName = "_type")]
        public string Type { get; set; }
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
    }

    public class About2
    {
        [JsonProperty(PropertyName = "readLink")]
        public string ReadLink { get; set; }
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
    }

    public class Provider2
    {
        [JsonProperty(PropertyName = "_type")]
        public string Type { get; set; }
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
    }

    public class ClusteredArticle
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        [JsonProperty(PropertyName = "about")]
        public List<About2> About { get; set; }
        [JsonProperty(PropertyName = "provider")]
        public List<Provider2> Provider { get; set; }
        [JsonProperty(PropertyName = "datePublished")]
        public string DatePublished { get; set; }
        [JsonProperty(PropertyName = "category")]
        public string Category { get; set; }
    }

    public class Mention
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
    }

    public class Thumbnail2
    {
        [JsonProperty(PropertyName = "width")]
        public int Width { get; set; }
        [JsonProperty(PropertyName = "height")]
        public int Height { get; set; }
    }

    public class Video
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        [JsonProperty(PropertyName = "thumbnailUrl")]
        public string thumbnailUrl { get; set; }
        [JsonProperty(PropertyName = "embedHtml")]
        public string embedHtml { get; set; }
        [JsonProperty(PropertyName = "allowHttpsEmbed")]
        public bool allowHttpsEmbed { get; set; }
        [JsonProperty(PropertyName = "thumbnail")]
        public Thumbnail2 thumbnail { get; set; }
    }

    public class NewsArticle
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }
        [JsonProperty(PropertyName = "image")]
        public Image Image { get; set; }
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        [JsonProperty(PropertyName = "about")]
        public List<About> About { get; set; }
        [JsonProperty(PropertyName = "provider")]
        public List<Provider> Provider { get; set; }
        [JsonProperty(PropertyName = "datePublished")]
        public string DatePublished { get; set; }
        [JsonProperty(PropertyName = "category")]
        public string Category { get; set; }
        [JsonProperty(PropertyName = "clusteredArticles")]
        public List<ClusteredArticle> ClusteredArticles { get; set; }
        [JsonProperty(PropertyName = "mentions")]
        public List<Mention> Mentions { get; set; }
        [JsonProperty(PropertyName = "video")]
        public Video Video { get; set; }
    }
}
