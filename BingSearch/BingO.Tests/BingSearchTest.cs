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

            //Assert.That(result.News.NewsSearchResults, Has.Some.Property(""));
            Assert.That(result.News.NewsSearchResults, Is.All.Not.Null);
        }

        [Test]
        public void ShouldSearchTrendingTopics()
        {

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
    }
}
