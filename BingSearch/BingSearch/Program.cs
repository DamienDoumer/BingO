using BingO;
using BingOResults;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BingSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ///Search about Bill Gates
                ///NB: This should be done asynchronously...
                SearchResult result = BingSearchHelper.Query("Bill Gates",
                    new BingQueryParameters(
                    apiKey: "",
                    count: 10,
                    offset: 0,
                    mkt: "en-us",
                    safeSearch: "Moderate")
                ).Result;

                ///Get a link to the first image of the search result.
                Console.WriteLine(result.Images.Value[0].ThumbnailUrl);

                Console.WriteLine("Done!!!!!!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + "\n" + e.StackTrace);
            }

            Console.ReadKey();
        }
    }
}
