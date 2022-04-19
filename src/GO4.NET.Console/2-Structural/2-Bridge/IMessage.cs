
namespace GO4.NET.Console._2_Structural._2_Bridge
{
    public interface IMessage
    {
        ISender Sender { get; set; }
        void Send();
        void Format();
    }
}
