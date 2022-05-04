using static System.Console;

namespace GO4.NET.Console._2_Structural._6_Flyweight.ConcreteImplementations
{
    public class ConcreteFlyweight : IFlyweight
    {
        public ConcreteFlyweight(string extrinsic) : base(extrinsic)
        {
        }
        public override void Operate(int id)
        {
            WriteLine("Flyweight: " + id);
        }
    }
}
