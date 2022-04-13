using static System.Console;
namespace GO4.NET.Console._1_Creational._3_FactoryMethod.ConcreteImplementations
{
    public class SQLProvider : IDataBaseProvider
    {
        public void Connect()
        {
            WriteLine($"Connection SQL Server");
        }

        public void RunQuery(string query)
        {
            WriteLine($"Executing SQL Server query: {query}");
        }
    }
}
