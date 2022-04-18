using static System.Console;
namespace GO4.NET.Console._2_Structural._1_Adapter.ConcreteImplementations
{
    public class ThreePinSocket : IEuropeanConector
    {
        public void Atter()
        {
            WriteLine("Attering");
        }

        public void Plug()
        {
            WriteLine("Plugging");
        }

        public void UnPlug()
        {
            WriteLine("Unplugging");
        }
    }
}
