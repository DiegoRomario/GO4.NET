using static System.Console;

namespace GO4.NET.Console._2_Structural._5_Facade.ConcreteImplementations
{
    public class PaymentGatewayFacade : IPaymentGatewayFacade
    {
        public bool Authorize(Order order)
        {
            bool authorized = new Random().Next(0, 3) == 1;

            if (authorized) WriteLine("Authorized payment!");
            else WriteLine("Unauthorized payment!");

            return authorized;
        }

        public void Pay(Order Order)
        {
            WriteLine($"Paying the amount of {Order.Amount}!");
        }

        public bool ValidToken(string token)
        {
            return token.Contains('A');
        }
    }
}
