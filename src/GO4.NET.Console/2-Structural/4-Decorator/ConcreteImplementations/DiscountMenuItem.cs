namespace GO4.NET.Console._2_Structural._4_Decorator.ConcreteImplementations
{
    public class DiscountMenuItem : IMenuItem
    {
        private readonly IMenuItem _menuItem;
        private readonly double _discountPercentage;

        public double Price => _menuItem.Price - (_menuItem.Price * (_discountPercentage / 100));

        public string Name => _menuItem.Name;
        public bool IsSpecial => _menuItem.IsSpecial;

        public DiscountMenuItem(IMenuItem menuItem, double discountPercentage)
        {
            _menuItem = menuItem;
            _discountPercentage = discountPercentage;
        }

        public override string ToString()
        {
            string specialDisplay = IsSpecial ? "### SPECIAL ###" : string.Empty;
            return $"{specialDisplay} \n {Name}: {Price:C}";
        }
    }
}
