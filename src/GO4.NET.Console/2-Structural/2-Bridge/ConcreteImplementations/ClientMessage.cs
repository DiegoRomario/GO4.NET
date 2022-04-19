using static System.Console;

namespace GO4.NET.Console._2_Structural._2_Bridge.ConcreteImplementations
{
    public class ClientMessage : IMessage
    {
        public ISender Sender { get; set; }

        public void Format()
        {
            WriteLine(new String('-', 50));
            WriteLine("My Client Message");
            WriteLine(new String('-', 50));
        }

        public void Send()
        {
            WriteLine("Sending Client Message");
            Sender.Send(this);
        }
    }
}
