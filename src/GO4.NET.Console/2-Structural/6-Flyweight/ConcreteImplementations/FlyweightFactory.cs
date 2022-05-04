using static System.Console;


namespace GO4.NET.Console._2_Structural._6_Flyweight.ConcreteImplementations
{
    public class FlyweightFactory
    {
        private static Dictionary<string, IFlyweight> pool = new Dictionary<string, IFlyweight>();

        public static IFlyweight GetFlyweight(string extrinsic)
        {
            IFlyweight flyweight;
            if (pool.ContainsKey(extrinsic))
            {
                flyweight = pool[extrinsic];
                WriteLine($"Already exists {extrinsic} ");
            }
            else
            {
                flyweight = new ConcreteFlyweight(extrinsic);
                pool.Add(extrinsic, flyweight);
                WriteLine($"New {extrinsic} ");
            }
            return flyweight;
        }
    }
}