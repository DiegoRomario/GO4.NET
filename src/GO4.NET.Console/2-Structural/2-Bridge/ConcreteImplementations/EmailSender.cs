using static System.Console;

namespace GO4.NET.Console._2_Structural._2_Bridge.ConcreteImplementations
{
    public class EmailSender : ISender
    {
        public void Send(IMessage message)
        {
            message.Format();
            WriteLine("By e-mail");
        }
    }
}
