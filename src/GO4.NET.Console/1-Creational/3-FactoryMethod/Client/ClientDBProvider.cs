using Microsoft.Extensions.Configuration;

namespace GO4.NET.Console._1_Creational._3_FactoryMethod.Client
{
    internal class ClientDBProvider
    {
        const string DBProviderFromAppSettings = "SQL";
        private readonly IDataBaseProvider dataBaseProvider;

        public ClientDBProvider()
        {
            dataBaseProvider = IDataBaseProviderFactory.Create(DBProviderFromAppSettings).GetDataBaseProvider();
        }
        public void Connect()
        {

            dataBaseProvider.Connect();
        }
        public void ExecQuery(string query)
        {
            dataBaseProvider.RunQuery(query);
        }
    }
}
