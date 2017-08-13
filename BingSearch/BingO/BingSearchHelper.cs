using System;
using System.Net.Http.Headers;
using System.Text;
using System.Net.Http;
using System.Web;
using System.Threading.Tasks;
using System.Diagnostics;
using BingOWebSearchResults.Exceptions;
using BingOWebSearchResults;
using BingO.CategoryNewsResult;
using BingO.TrendingTopicsNewsResults;
using BingO.GlobalNewsResults;

namespace BingO
{
    public class BingSearchHelper
    {
        private const string WEB_SEARCH_REQUEST_URL = "https://api.cognitive.microsoft.com/bing/v5.0/search?";
        private const string NEWS_SEARCH_REQUEST_URL = "https://api.cognitive.microsoft.com/bing/v5.0/news/search?";
        private const string TRENDING_TOPICS_REQUEST_URL = "https://api.cognitive.microsoft.com/bing/v5.0/news/trendingtopics/";
        private const string CATEGORY_NEWS_REQUEST_URL = "https://api.cognitive.microsoft.com/bing/v5.0/news/?Category=";

        /// <summary>
        /// Queries the Bing Search API online
        /// </summary>
        /// <param name="query">The Query the user searches for</param>
        /// <param name="parameters">Query Parameters, to Enance searching criterias</param>
        /// <returns></returns>
        public static async Task<SearchResult> WebSearch(string query, BingQueryParameters parameters, string apiKey)
        {
            string uri = BuildQueryString(query, parameters, WEB_SEARCH_REQUEST_URL);
            string respString = await QueryBingAsync(uri, apiKey);

            var searchResult = Newtonsoft.Json.JsonConvert.DeserializeObject<SearchResult>(respString);

            HandleException(searchResult.StatusCode, searchResult.Message);

            return searchResult;
        }

        /// <summary>
        /// Search news For any prefered domain or topic the user preffers
        /// </summary>
        /// <param name="query"></param>
        /// <param name="parameters"></param>
        /// <param name="apiKey"></param>
        /// <returns></returns>
        public static async Task<GlobalNewsSearchResult> SearchNewsGlobally(string query, BingQueryParameters parameters, string apiKey)
        {
            string uri = BuildQueryString(query, parameters, NEWS_SEARCH_REQUEST_URL);
            string respString = await QueryBingAsync(uri, apiKey);

            var searchResult = Newtonsoft.Json.JsonConvert.DeserializeObject<GlobalNewsSearchResult>(respString);

            HandleException(searchResult.StatusCode, searchResult.Message);

            return searchResult;
        }

        /// <summary>
        /// Search Bing Api for News ranked by Category
        /// </summary>
        /// <param name="newsCategories">News Categories</param>
        /// <returns>News Articles found</returns>
        public async static Task<CategoryNewsSearchResult> SearchNewsByCategory(NewsCategories newsCategories, string apiKey)
        {
            string category = string.Empty;

            if (newsCategories == NewsCategories.US_UK)
            {
                category = "US/UK";
            }
            else
            {
                category = newsCategories.ToString();
            }

            string queryString = CATEGORY_NEWS_REQUEST_URL + category;
            var respString = await QueryBingAsync(queryString, apiKey);
            var searchResult = Newtonsoft.Json.JsonConvert.DeserializeObject<CategoryNewsSearchResult>(respString);

            HandleException(searchResult.StatusCode, searchResult.Message);

            return searchResult;
        }

        /// <summary>
        /// Search bing for news by trending topics
        /// </summary>
        /// <param name="apiKey"></param>
        /// <returns></returns>
        public async static Task<TrendingTopicsNewsSearchResult> SearchNewsByTrendingTopics(string apiKey)
        {
            var respString = await QueryBingAsync(CATEGORY_NEWS_REQUEST_URL, apiKey);
            var searchResult = Newtonsoft.Json.JsonConvert.DeserializeObject<TrendingTopicsNewsSearchResult>(respString);

            HandleException(searchResult.StatusCode, searchResult.Message);

            return searchResult;
        }

        /// <summary>
        /// Queries BingSearch API online for what ever is needed
        /// </summary>
        /// <param name="uri">the Uri to the online server</param>
        /// <returns>Json Response to query</returns>
        private static async Task<string> QueryBingAsync(string uri, string apiKey)
        {
            string respString = string.Empty;

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", $"{apiKey}");
                    var response = await client.GetAsync(uri);
                    respString = await response.Content.ReadAsStringAsync();
                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            return respString;
        }

        /// <summary>
        /// Constructs the URL which will be used for querying
        /// </summary>
        /// <param name="query">What is searched for</param>
        /// <param name="parameters">Parameters for research Criterias</param>
        /// <returns>A Well structured URI Which can be used to query the internet</returns>
        private static string BuildQueryString(string query, BingQueryParameters parameters, string requestURL)
        {
            var queryString = HttpUtility.ParseQueryString(string.Empty);
            queryString["q"] = query;

            foreach (var property in parameters.GetType().GetProperties())
            {
                if (property.Name.Equals("APIKey") || property.GetValue(parameters) == null)
                {
                    continue;
                }
                else
                {
                    //Get the property's name and its value and set it to the query string
                    queryString[property.Name.ToLower()] = property.GetValue(parameters).ToString();
                }
            }

            return requestURL + queryString;
        }

        private static void HandleException(int statusCode, string message)
        {
            switch (statusCode)
            {
                case 403:
                    throw new OutOfCallVolumeQuotaException(message);
                case 401:
                    throw new AccessDeniedException(message);
                case 429:
                    throw new RateLimitExceededException(message);
                default:
                    break;
            }
        }
    }
}
