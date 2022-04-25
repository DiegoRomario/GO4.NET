using static System.Console;
namespace GO4.NET.Console._2_Structural._3_Composite.ConcreteImplementations
{
    public class Form : Component
    {

        private readonly List<Component> _components;

        public Form(string nome, float x, float y) : base(nome, x, y)
        {
            _components = new List<Component>();
        }

        public override void Add(Component component)
        {
            WriteLine($"Adding [{component.Name}] in [{Name}]");
            _components.Add(component);
        }

        public override void Show()
        {
            WriteLine($"Showing [{Name}] and components");
            foreach (var item in _components) item.Show();

        }

        public override void Remove(Component component)
        {
            WriteLine($"Removing [{component.Name}] from [{Name}]");
            _components.Remove(component);
        }
    }
}
