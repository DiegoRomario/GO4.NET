namespace GO4.NET.Console._2_Structural._5_Facade.ConcreteImplementations
{
    public class Order
    {
        public Order(DateTime date, decimal amount)
        {
            Date = date;
            Amount = amount;
        }

        public DateTime Date { get; set; }
        public decimal Amount { get; set; }

    }
}
