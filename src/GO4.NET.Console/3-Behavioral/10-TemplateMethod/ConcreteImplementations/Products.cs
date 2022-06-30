using static System.Console;
namespace GO4.NET.Console._3_Behavioral._10_TemplateMethod.ConcreteImplementations
{
    public class Products : DataAccessor
    {
        private List<string> products;
        public override void Connect()
        {
            products = new List<string>();
        }
        public override void Select()
        {
            products.Add("Car");
            products.Add("Bike");
            products.Add("Boat");
            products.Add("Truck");
            products.Add("Moped");
            products.Add("Rollerskate");
            products.Add("Stroller");
        }
        public override void Process(int top)
        {
            WriteLine("-- Products --");
            for (int i = 0; i < top; i++) WriteLine(products[i]);
            WriteLine();
        }
        public override void Disconnect()
        {
            products.Clear();
        }
    }

}
