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

namespace BingO
{
    public class BingSearchHelper
    {
        private const string WEB_SEARCH_REQUEST_URL = "https://api.cognitive.microsoft.com/bing/v5.0/search?";
        private const string NEWS_SEARCH_REQUEST_URL = "https://api.cognitive.microsoft.com/bing/v5.0/news/";
        private const string TRENDING_TOPICS_REQUEST_URL = "https://api.cognitive.microsoft.com/bing/v5.0/news/trendingtopics/";
        private const string CATEGORY_NEWS_REQUEST_URL = "https://api.cognitive.microsoft.com/bing/v5.0/news/?Category=";

        /// <summary>
        /// Queries the Bing Search API online
        /// </summary>
        /// <param name="query">The Query the user searches for</param>
        /// <param name="parameters">Query Parameters, to Enance searching criterias</param>
        /// <param name="type">Search type, either news search, WebSearch...</param>
        /// <returns></returns>
        public static async Task<SearchResult> Query(SearchType type, string query = "", BingQueryParameters parameters = null)
        {
            HttpClient client = new HttpClient();
            string uri = string.Empty ;
            //string uri = BuildQueryString(query, parameters);

            switch (type)
            {
                case SearchType.TrendingTopics:
                    uri = TRENDING_TOPICS_REQUEST_URL;
                    break;
                case SearchType.News:
                    uri = NEWS_SEARCH_REQUEST_URL + BuildQueryString(query, parameters);
                    break;
                case  SearchType.WebSearch:
                    uri = NEWS_SEARCH_REQUEST_URL + BuildQueryString(query, parameters);
                    break;
                case SearchType.CategoryNews:
                    uri = CATEGORY_NEWS_REQUEST_URL;
                    break;
            }
           
            var response = await client.GetAsync(uri);
            string respString = await response.Content.ReadAsStringAsync();

            var searchResult = Newtonsoft.Json.JsonConvert.DeserializeObject<SearchResult>(respString);


            switch (searchResult.StatusCode)
            {
                case 403:
                    throw new OutOfCallVolumeQuotaException(searchResult.Message);
                case 401:
                    throw new AccessDeniedException(searchResult.Message);
                case 429:
                    throw new RateLimitExceededException(searchResult.Message);
                default:
                    break;
            }

            return searchResult;
        }

        /// <summary>
        /// Search Bing Api for News ranked by Category
        /// </summary>
        /// <param name="newsCategories">News Categories</param>
        /// <returns>News Articles found</returns>
        public async static Task<CategoryNewsSearchResult> SearchNewsByCategory(NewsCategories newsCategories)
        {
            var respString = await QueryBingAsync(CATEGORY_NEWS_REQUEST_URL + newsCategories.ToString());
            var searchResult = Newtonsoft.Json.JsonConvert.DeserializeObject<CategoryNewsSearchResult>(respString);

            return searchResult;
        }

        /// <summary>
        /// Queries BingSearch API online for what ever is needed
        /// </summary>
        /// <param name="uri">the Uri to the online server</param>
        /// <returns>Json Response to query</returns>
        private static async Task<string> QueryBingAsync(string uri)
        {
            string respString = string.Empty;

            using (HttpClient client = new HttpClient())
            {
                try
                {
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
        private static string BuildQueryString(string query, BingQueryParameters parameters)
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
                    queryString[property.Name] = property.GetValue(parameters).ToString();
                }
            }

            return Convert.ToString(queryString);
        }
    }
}
