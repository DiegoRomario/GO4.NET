using static System.Console;


namespace GO4.NET.Console._1_Creational._3_FactoryMethod.ConcreteImplementations
{
    internal class OracleProvider : IDataBaseProvider
    {
        public void Connect()
        {
            WriteLine($"Connection to Oracle");
        }

        public void RunQuery(string query)
        {
            WriteLine($"Executing Oracle query: {query}");
        }

    }
}
