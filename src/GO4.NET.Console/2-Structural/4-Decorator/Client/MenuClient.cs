using static System.Console;
using GO4.NET.Console._2_Structural._4_Decorator.ConcreteImplementations;

namespace GO4.NET.Console._2_Structural._4_Decorator.Client
{
    public static class MenuClient
    {
        public static void ShowMenuItens()
        {
            IMenu menu = new Menu(new List<MenuItem>()
            { new MenuItem("Burger", 20, false),
              new MenuItem("Pizza", 50, false)});

            menu = new DailySpecialMenu(menu, new MenuItem("Soda", 5, true));
            menu = new DiscountMenu(menu, 10);

            foreach (var item in menu.Items)
            {
                WriteLine(item);
            }
        }

    }
}
