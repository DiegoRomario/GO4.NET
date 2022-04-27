namespace GO4.NET.Console._2_Structural._4_Decorator.ConcreteImplementations
{
    public class Menu : IMenu
    {
        public IEnumerable<IMenuItem> Items { get; }

        public Menu(IEnumerable<IMenuItem> menuItems)
        {
            Items = menuItems;
        }
    }
}
