using GO4.NET.Console._2_Structural._5_Facade.ConcreteImplementations;
using static System.Console;

namespace GO4.NET.Console._2_Structural._5_Facade.Client
{
    public static class PaymentClient
    {
        public static void PayOrders()
        {
            var orders = new List<Order>() {
                new Order(DateTime.Now, 5632),
                new Order(DateTime.Now.AddDays(-2), 1253)
            };

            foreach (var order in orders)
            {
                new PaymentService(new PaymentGatewayFacade(), "A1WGVEV2346679887FFTRWEV12122112CWEVWE12").Pay(order);
                WriteLine(new String('-', 40));
            }

        }
    }
}
