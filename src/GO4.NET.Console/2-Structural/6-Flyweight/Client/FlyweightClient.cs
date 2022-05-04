using GO4.NET.Console._2_Structural._6_Flyweight.ConcreteImplementations;

namespace GO4.NET.Console._2_Structural._6_Flyweight.Client
{
    public static class FlyweightClient
    {
        public static void Show()
        {
            int id = 0;
            IFlyweight flyweightA = FlyweightFactory.GetFlyweight("A");
            flyweightA.Operate(++id);
            IFlyweight flyweightB = FlyweightFactory.GetFlyweight("B");
            flyweightB.Operate(++id);
            IFlyweight flyweightA1 = FlyweightFactory.GetFlyweight("A");
            flyweightA1.Operate(++id);
            IFlyweight flyweightB1 = FlyweightFactory.GetFlyweight("B");
            flyweightB1.Operate(++id);
        }
    }
}
