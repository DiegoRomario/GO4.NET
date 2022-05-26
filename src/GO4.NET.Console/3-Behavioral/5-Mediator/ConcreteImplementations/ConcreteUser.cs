using static System.Console;
namespace GO4.NET.Console._3_Behavioral._5_Mediator.ConcreteImplementations
{
    public class ConcreteUser : User
    {
        public ConcreteUser(IFacebookGroupMediator mediator, string nome) : base(mediator, nome)
        {

        }
        public override void ReceiveMessage(string message)
        {
            WriteLine($"{name} : received <= {message}");
        }

        public override void Send(string message)
        {
            WriteLine($"{name} : sent => {message}");
            mediator.SendMessage(message, this);
        }
    }
}
