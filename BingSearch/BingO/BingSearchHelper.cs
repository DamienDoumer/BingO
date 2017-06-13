using System;
using System.Net.Http.Headers;
using System.Text;
using System.Net.Http;
using System.Web;
using System.Threading.Tasks;
using System.Diagnostics;
using BingOResults.Exceptions;
using BingOResults;
using System.IO;

namespace BingO
{
    public class BingSearchHelper
    {
        /// <summary>
        /// Query's the bing search api for anything
        /// </summary>
        /// <param name="query"></param>
        /// <param name="parameters"></param>
        /// <returns>Search result containing links, images, news...</returns>
        public static async Task<SearchResult> Query(string query, BingQueryParameters parameters)
        {
            HttpClient client = new HttpClient();
            var queryString = HttpUtility.ParseQueryString(string.Empty);

            

            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", $"{parameters.APIKey}");
            queryString["q"] = query;
            foreach(var property in parameters.GetType().GetProperties())
            {
                if(property.Name.Equals("APIKey") || property.GetValue(parameters) == null)
                {
                    continue;
                }
                else
                {
                    //Get the property's name and its value and set it to the query string
                    queryString[property.Name] = property.GetValue(parameters).ToString();
                }
            }

            var uri = "https://api.cognitive.microsoft.com/bing/v5.0/search?" + queryString;

            Debug.WriteLine(uri.ToString());

            var response = await client.GetAsync(uri);
            string respString = await response.Content.ReadAsStringAsync();
            
            var searchResult = Newtonsoft.Json.JsonConvert.DeserializeObject<SearchResult>(respString);


            switch (searchResult.StatusCode)
            {
                case 403:
                    throw new OutOfCallVolumeQuotaException(searchResult.Message);
                    break;
                case 401:
                    throw new AccessDeniedException(searchResult.Message);
                    break;
                case 429:
                    throw new RateLimitExceededException(searchResult.Message);
                default:
                    break;
            }
            
            return searchResult;
        }
    }
}
