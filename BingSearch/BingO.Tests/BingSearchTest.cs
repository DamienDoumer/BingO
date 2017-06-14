using BingOResults;
using NUnit.Framework;
using System.Configuration;
using System.IO;

namespace BingO.Tests
{
    [TestFixture]
    public class BingSearchTest
    {
        string query = "Bill Gates";
        //string reamera = ConfigurationManager.AppSettings["reamera"];

        [Test]
        public void ShouldSearchWeb()
        {
            string k = GetKey();

            SearchResult result = BingSearchHelper.Query(query,
                   new BingQueryParameters(
                   apiKey: k,
                   count: 10,
                   offset: 0,
                   mkt: "en-us",
                   safeSearch: "Moderate")
               , SearchType.NormalSearch).Result;

            Assert.That(result, Is.Not.Null);
        }

        [Test]
        public void ShouldSearchImages()
        {
            string k = GetKey();

            SearchResult result = BingSearchHelper.Query(query,
                   new BingQueryParameters(
                   apiKey: k,
                   count: 10,
                   offset: 0,
                   mkt: "en-us",
                   safeSearch: "Moderate")
               , SearchType.NormalSearch).Result;

            Assert.That(result.Images.Value, Is.Not.Null);
        }

        [Test]
        public void ShouldSearchNews()
        {

        }

        [Test]
        public void ShouldSearchTrendingTopics()
        {

        }

        [Test]
        public void ShouldSearchVideos()
        {

        }
        
        private string GetKey()
        {
            StreamReader reader = new StreamReader(@"E:\API_Key.txt");
            string key = reader.ReadToEnd();
            reader.Close();

            return key;
        }
    }
}
