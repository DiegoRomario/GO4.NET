namespace GO4.NET.Console._1_Creational._3_FactoryMethod.ConcreteImplementations
{
    internal class OracleProviderFactory : IDataBaseProviderFactory
    {
        public override IDataBaseProvider GetDataBaseProvider()
        {
            return new OracleProvider();
        }
    }
}
