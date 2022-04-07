namespace GO4.NET.Console._1_Creational._2_Builder
{
    public interface IHTTPRequestBuilder
    {
        public IHTTPRequestBuilder SetBaseURL(string baseUrl);
        public IHTTPRequestBuilder SetEndPoint(string url);
        public IHTTPRequestBuilder SetCredentials(string login, string password);
        public IHTTPRequestBuilder SetHeaders(Dictionary<string, string> headers);
        public HTTPRequest Build();
    }
}
