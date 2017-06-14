using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingO.TrendingTopicsNewsSearchResults
{
    public class NewsSearchResult
    {
    }

    public class Provider
    {
        public string _type { get; set; }
        public string name { get; set; }
    }

    public class Image
    {
        public string url { get; set; }
        public List<Provider> provider { get; set; }
    }

    public class Query
    {
        public string text { get; set; }
    }

    public class NewsArticle
    {
        public string name { get; set; }
        public Image image { get; set; }
        public string webSearchUrl { get; set; }
        public bool isBreakingNews { get; set; }
        public Query query { get; set; }
    }

    public class RootObject
    {
        public string _type { get; set; }
        public List<NewsArticle> value { get; set; }
    }
}
