
namespace GO4.NET.Console._2_Structural._4_Decorator.ConcreteImplementations
{
    public class DailySpecialMenu : IMenu
    {
        private readonly IMenu _menu;
        private readonly IMenuItem _dailySpecialMenuItem;

        public IEnumerable<IMenuItem> Items => _menu.Items.Append(_dailySpecialMenuItem);

        public DailySpecialMenu(IMenu menu, IMenuItem dailySpecialMenuItem)
        {
            _menu = menu;
            _dailySpecialMenuItem = dailySpecialMenuItem;
        }
    }
}
