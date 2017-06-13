namespace BingO
{
    public class BingQueryParameters
    {
        public int count { get; set; }
        public int offset { get; set; }
        public string mkt { get; set; }
        public string safesearch { get; set; }
        public string APIKey { get; set; }

        public BingQueryParameters(string apiKey, string mkt, int count, int offset, string safeSearch)
        {
            this.count = count;
            APIKey = apiKey;
            this.offset = offset;
            safesearch = safeSearch;
            this.mkt = mkt;
        }
    }
}
