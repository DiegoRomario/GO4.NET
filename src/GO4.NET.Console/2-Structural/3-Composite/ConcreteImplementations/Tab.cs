using static System.Console;

namespace GO4.NET.Console._2_Structural._3_Composite.ConcreteImplementations
{
    public class Tab : Component
    {

        private readonly List<Component> _Components;

        public Tab(string name, float x, float y) : base(name, x, y)
        {
            _Components = new List<Component>();
        }

        public override void Add(Component component)
        {
            WriteLine($"Adding [{component.Name}] in [{Name}]");
            _Components.Add(component);
        }

        public override void Show()
        {
            WriteLine($"Showing [{Name}] and components");
            foreach (var item in _Components) item.Show();

        }

        public override void Remove(Component component)
        {
            WriteLine($"Removing [{component.Name}] from [{Name}]");
            _Components.Remove(component);
        }
    }
}
