using static System.Console;

namespace GO4.NET.Console._2_Structural._5_Facade.ConcreteImplementations
{
    public class PaymentService : IPayment
    {
        private readonly IPaymentGatewayFacade _paymentGatewayFacade;
        private readonly string _token;

        public PaymentService(IPaymentGatewayFacade paymentGatewayFacade, string token)
        {
            _paymentGatewayFacade = paymentGatewayFacade;
            _token = token;
        }

        public void Pay(Order order)
        {
            if (_paymentGatewayFacade.ValidToken(_token))
            {
                if (_paymentGatewayFacade.Authorize(order))
                    _paymentGatewayFacade.Pay(order);
            }
            else
            {
                WriteLine("Invalid Token");
            }
        }
    }
}
