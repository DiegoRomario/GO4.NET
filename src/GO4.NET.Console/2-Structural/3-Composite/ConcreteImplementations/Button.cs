using static System.Console;

namespace GO4.NET.Console._2_Structural._3_Composite.ConcreteImplementations
{
    public class Button : Component
    {
        public Button(string nome, float x, float y) : base(nome, x, y)
        {
        }

        public override void Add(Component component)
        {
            WriteLine("Cannot add a component to a button");
        }

        public override void Show()
        {
            WriteLine($"Component: [{Name}] located in [{X}] and [{Y}] of the screen");
        }

        public override void Remove(Component component)
        {
            WriteLine("There are no components to be removed");
        }
    }
}
