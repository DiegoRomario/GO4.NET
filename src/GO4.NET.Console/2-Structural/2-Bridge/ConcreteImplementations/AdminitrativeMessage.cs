using static System.Console;

namespace GO4.NET.Console._2_Structural._2_Bridge.ConcreteImplementations
{
    internal class AdminitrativeMessage : IMessage
    {
        public ISender Sender { get; set; }

        public void Format()
        {
            WriteLine(new String('#', 50));
            WriteLine("My Administrative Message");
            WriteLine(new String('#', 50));
        }

        public void Send()
        {
            WriteLine("Sending Administrative Message");
            Sender.Send(this);
        }
    }
}
