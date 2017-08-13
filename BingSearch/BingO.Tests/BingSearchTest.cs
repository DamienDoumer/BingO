using BingO.CategoryNewsResult;
using BingO.GlobalNewsResults;
using BingO.TrendingTopicsNewsResults;
using BingOWebSearchResults;
using NUnit.Framework;
using System.Configuration;
using System.IO;
using System.Threading.Tasks;

namespace BingO.Tests
{
    [TestFixture]
    public class BingSearchTest
    {
        string query = "Bill Gates";
        //string key = ConfigurationManager.AppSettings["reamera"];

        [Test]
        public void ShouldSearchWebForArticles()
        {
            string k = GetKey();

            var result = SearchWeb(query).Result;

            //Check if the collecction has 
            Assert.That(result.WebSearchResult.WebPages, Is.All.Not.Null);
        }

        [Test]
        public void ShouldSearchWebForArticlesWithCountryAndLanguage()
        {
            string k = GetKey();
            
            var result = SearchWebWithCountryLanguage(query).Result;

            //Check if the collecction has 
            Assert.That(result.WebSearchResult.WebPages, Is.All.Not.Null);
        }

        [Test]
        public void ShouldSearchImages()
        {
            string k = GetKey();

            var result = SearchWeb(query).Result;

            Assert.That(result.Images.ImageResults, Is.All.Not.Null);
        }

        [Test]
        public void ShouldSearchNews()
        {
            string k = GetKey();

            var result = SearchWeb(query).Result;
            
            Assert.That(result.News.NewsSearchResults, Is.All.Not.Null);
        }

        [Test]
        public async Task ShouldSearchNewsByTrendingTopicsAsync()
        {
            string k = GetKey();

            TrendingTopicsNewsSearchResult trendingTop = await BingSearchHelper.SearchNewsByTrendingTopics(k);

            Assert.That(trendingTop.NewsArticles, Is.All.Not.Null);
        }

        [Test]
        public async Task ShouldSearchNewsByCategory()
        {
            string k = GetKey();

            CategoryNewsSearchResult categoryNews = await BingSearchHelper.SearchNewsByCategory(NewsCategories.Health, k);

            Assert.That(categoryNews.NewsArticles, Is.Not.Null);
        }

        [Test]
        public async Task ShouldSearchNewsGloaballyForAnyTopic()
        {
            string k = GetKey();

            GlobalNewsSearchResult global = await BingSearchHelper.SearchNewsGlobally(query, new BingQueryParameters()
            {
                Count = 10,
                Offset = 0,
                MKT = "en-us"
            }, k);

            Assert.That(global.NewsArticles, Is.All.Not.Null);
        }

        [Test]
        public void ShouldSearchVideos()
        {
            string k = GetKey();

            var result = SearchWeb(query).Result;

            Assert.That(result.Videos.VideoSearchResult, Is.All.Not.Null);
        }
        
        private string GetKey()
        {
            StreamReader reader = new StreamReader(@"E:\API_Key.txt");
            string key = reader.ReadToEnd();
            reader.Close();

            return key;
        }

        private async Task<SearchResult> SearchWeb(string q)
        {
            SearchResult result = await BingSearchHelper.WebSearch(query,
                   new BingQueryParameters()
                   {
                       Count = 10,
                       Offset = 0,
                       MKT = "en-us",
                       SafeSearch = "Moderate"
                   }
               , GetKey());

            return result;
        }

        private async Task<SearchResult> SearchWebWithCountryLanguage(string q)
        {
            SearchResult result = await BingSearchHelper.WebSearch(query,
                  new BingQueryParameters()
                  {
                      Count = 10,
                      Offset = 0,
                      MKT = "en-us",
                      SafeSearch = "Moderate",
                      Language = "fr",
                      Loc = "fr"
                  }
              , GetKey());

            return result;
        }
    }
}
