using GO4.NET.Console._2_Structural._2_Bridge.ConcreteImplementations;

namespace GO4.NET.Console._2_Structural._2_Bridge.Client
{
    public class SenderMessagesClient
    {
        public void Send()
        {
            ISender sender = new EmailSender();
            IMessage message = new ClientMessage();
            message.Sender = sender;
            message.Send();
        }
    }
}
