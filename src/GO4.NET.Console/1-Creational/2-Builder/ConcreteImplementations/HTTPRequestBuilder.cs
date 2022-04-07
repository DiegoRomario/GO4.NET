namespace GO4.NET.Console._1_Creational._2_Builder.ConcreteImplementations
{
    public class HTTPRequestBuilder : IHTTPRequestBuilder
    {
        readonly HTTPRequest request = new();
        public IHTTPRequestBuilder SetBaseURL(string baseUrl)
        {
            request.BaseUrl = baseUrl;
            return this;
        }

        public IHTTPRequestBuilder SetCredentials(string login, string password)
        {
            request.Login = login;
            request.Login = password;
            return this;
        }

        public IHTTPRequestBuilder SetEndPoint(string url)
        {
            request.Endpoint = url;
            return this;
        }

        public IHTTPRequestBuilder SetHeaders(Dictionary<string, string> headers)
        {
            request.Headers = headers;
            return this;
        }

        public HTTPRequest Build()
        {
            return request;
        }

    }
}
