
using GO4.NET.Console._1_Creational._3_FactoryMethod.ConcreteImplementations;

namespace GO4.NET.Console._1_Creational._3_FactoryMethod
{
    abstract class IDataBaseProviderFactory
    {
        public abstract IDataBaseProvider GetDataBaseProvider();

        public static IDataBaseProviderFactory Create(string provider)
        {
            switch (provider)
            {
                case "SQL":
                    return new SQLProviderFactory();
                case "ORACLE":
                    return new OracleProviderFactory();
                default:
                    throw new IndexOutOfRangeException();
            }
        }
    }
}
