using static System.Console;
namespace GO4.NET.Console._2_Structural._1_Adapter.ConcreteImplementations
{
    public class TwoPinSocket : IConector
    {
        public void Conect()
        {
            WriteLine("Connecting");
        }

        public void Desconect()
        {
            WriteLine("Disconnecting");
        }
    }
}
