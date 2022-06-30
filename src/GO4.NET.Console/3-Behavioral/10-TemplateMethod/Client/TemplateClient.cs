using GO4.NET.Console._3_Behavioral._10_TemplateMethod.ConcreteImplementations;
namespace GO4.NET.Console._3_Behavioral._10_TemplateMethod.Client
{
    public static class TemplateClient
    {
        public static void Run()
        {
            DataAccessor categories = new Categories();
            categories.Run(5);
            DataAccessor products = new Products();
            products.Run(3);
        }
    }
}
