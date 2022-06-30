using static System.Console;

namespace GO4.NET.Console._3_Behavioral._10_TemplateMethod.ConcreteImplementations
{
    public class Categories : DataAccessor
    {
        private List<string> categories;
        public override void Connect()
        {
            categories = new List<string>();
        }
        public override void Select()
        {
            categories.Add("Red");
            categories.Add("Green");
            categories.Add("Blue");
            categories.Add("Yellow");
            categories.Add("Purple");
            categories.Add("White");
            categories.Add("Black");
        }
        public override void Process(int top)
        {
            WriteLine("-- Categories --");
            for (int i = 0; i < top; i++) WriteLine(categories[i]);
            WriteLine();
        }
        public override void Disconnect()
        {
            categories.Clear();
        }
    }

}
