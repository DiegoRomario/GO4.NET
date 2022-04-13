
namespace GO4.NET.Console._1_Creational._3_FactoryMethod
{
    public interface IDataBaseProvider
    {
        public void Connect();
        public void RunQuery(string query);
    }
}
