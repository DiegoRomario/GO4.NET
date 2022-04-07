using static System.Console;
namespace GO4.NET.Console._1_Creational._2_Builder
{
    public class HTTPRequest
    {
        public HTTPRequest()
        {
        }
        public HTTPRequest(string baseUrl, string endpoint, Dictionary<string, string> headers, string login, string password)
        {
            BaseUrl = baseUrl;
            Endpoint = endpoint;
            Headers = headers;
            Login = login;
            Password = password;
        }

        public string BaseUrl { get; set; }
        public string Endpoint { get; set; }
        public Dictionary<string, string> Headers { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public void Exec()
        {
            WriteLine($@"Request to: {BaseUrl}{Endpoint}");
        }
    }
}
