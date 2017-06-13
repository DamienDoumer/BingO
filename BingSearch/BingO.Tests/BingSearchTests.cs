using System;
using NUnit.Framework;
using System.Configuration;
using BingOResults;

namespace BingO.Tests
{
    [TestFixture]   
    public class BingSearchTests
    {
        string query = "Bill Gates";
        string reamera = ConfigurationManager.AppSettings["reamera"];

        [Test]
        public void ShouldSearchWeb()
        {
            SearchResult result = BingSearchHelper.Query(query,
                   new BingQueryParameters(
                   apiKey: reamera,
                   count: 10,
                   offset: 0,
                   mkt: "en-us",
                   safeSearch: "Moderate")).Result;

            Assert.That(result, Is.Not.Null);
        }
    }
}
