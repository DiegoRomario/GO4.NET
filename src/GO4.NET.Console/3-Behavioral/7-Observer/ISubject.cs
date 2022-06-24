
namespace GO4.NET.Console._3_Behavioral._7_Observer
{
    public interface ISubject
    {
        void Attach(IObserver observer);
        void Detach(IObserver observer);
        void Notify();
    }
}
