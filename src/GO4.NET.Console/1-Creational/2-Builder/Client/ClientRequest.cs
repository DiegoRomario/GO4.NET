using GO4.NET.Console._1_Creational._2_Builder.ConcreteImplementations;

namespace GO4.NET.Console._1_Creational._2_Builder.Client
{
    public class ClientRequest
    {
        private readonly string BaseUrl;
        private readonly HTTPRequestBuilder mbuilder;

        public ClientRequest(HTTPRequestBuilder pbuilder, string baseUrl)
        {
            mbuilder = pbuilder;
            BaseUrl = baseUrl;
        }


        public void RequestNoAuth(string endPoint)
        {
            mbuilder.SetBaseURL(BaseUrl);
            mbuilder.SetEndPoint(endPoint);
            mbuilder.Build().Exec();
        }

    }
}
