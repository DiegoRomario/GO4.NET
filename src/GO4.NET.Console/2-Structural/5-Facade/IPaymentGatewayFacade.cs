using GO4.NET.Console._2_Structural._5_Facade.ConcreteImplementations;

namespace GO4.NET.Console._2_Structural._5_Facade
{
    public interface IPaymentGatewayFacade
    {
        bool Authorize(Order order);
        void Pay(Order order);
        bool ValidToken(string token);
    }
}
