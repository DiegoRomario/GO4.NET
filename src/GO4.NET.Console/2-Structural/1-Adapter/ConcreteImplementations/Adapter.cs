using static System.Console;
namespace GO4.NET.Console._2_Structural._1_Adapter.ConcreteImplementations
{
    public class Adapter : IConector
    {
        private readonly IEuropeanConector _europeanNonector;

        public Adapter(IEuropeanConector europeanNonector)
        {
            _europeanNonector = europeanNonector;
        }

        public void Conect()
        {
            RemoveThirdPin();
            _europeanNonector.Plug();
        }

        public void Desconect()
        {
            _europeanNonector.UnPlug();
        }

        public void RemoveThirdPin()
        {
            WriteLine("Removing Third Pin");
        }
    }
}
