using static System.Console;

namespace GO4.NET.Console._2_Structural._6_Flyweight.ConcreteImplementations
{
    public class UnsharedConcreteFlyweight : IFlyweight
    {

        public UnsharedConcreteFlyweight(string extrinsic) : base(extrinsic)
        {
        }

        public override void Operate(int id)
        {
            WriteLine("Not Shared Flyweight: " + id);
        }
    }
}
