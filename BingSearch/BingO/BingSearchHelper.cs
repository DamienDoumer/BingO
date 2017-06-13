using System;
using System.Net.Http.Headers;
using System.Text;
using System.Net.Http;
using System.Web;
using System.Threading.Tasks;
using System.Diagnostics;
using BingOResults.Exceptions;
using BingOResults;

namespace BingO
{
    public class BingSearchHelper
    {
        private const string WEB_SEARCH_REQUEST_URL = "https://api.cognitive.microsoft.com/bing/v5.0/search?";
        private const string NEWS_SEARCH_REQUEST_URL = "https://api.cognitive.microsoft.com/bing/v5.0/news/";
        private const string TRENDING_TOPICS_REQUEST_URL = "https://api.cognitive.microsoft.com/bing/v5.0/news/trendingtopics/";


        public static async Task<SearchResult> Query(string query, BingQueryParameters parameters, SearchType type)
        {
            HttpClient client = new HttpClient();
            string uri = BuildQueryString(query, parameters);

            switch (type)
            {
                case SearchType.News:
                    uri = NEWS_SEARCH_REQUEST_URL + BuildQueryString(query, parameters);
                    break;
                case  SearchType.NormalSearch:
                    uri = NEWS_SEARCH_REQUEST_URL + BuildQueryString(query, parameters);
                    break;
                case SearchType.TrendingTopics:
                    uri = TRENDING_TOPICS_REQUEST_URL + BuildQueryString(query, parameters);
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
        /// Constructs the URL which will be used for querying
        /// </summary>
        /// <param name="query"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
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
