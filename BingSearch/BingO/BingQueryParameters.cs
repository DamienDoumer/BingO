namespace BingO
{
    public class BingQueryParameters
    {
        public int Count { get; set; }
        public int Offset { get; set; }
        public string MKT { get; set; }
        public string SafeSearch { get; set; }
        public string APIKey { get; set; }
        public string Loc { get; set; }
        public string Language { get; set; }

        public BingQueryParameters(string apiKey, string mkt, int count, int offset, string safeSearch, string loc = null, string language = null)
        {
            this.Count = count;
            APIKey = apiKey;
            this.Offset = offset;
            SafeSearch = safeSearch;
            this.MKT = mkt;
            Loc = loc;
            Language = language;
        }

        public BingQueryParameters()
        {

        }
    }
}
