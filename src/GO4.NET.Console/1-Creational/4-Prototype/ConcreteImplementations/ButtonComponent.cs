using static System.Console;

namespace GO4.NET.Console._1_Creational._4_Prototype.ConcreteImplementations
{
    public class ButtonComponent : IComponentPrototype
    {
        public override void Action()
        {
            WriteLine($"{this.GetType().Name} pressed successfully");
        }

        public override IComponentPrototype Clone()
        {
            return this.MemberwiseClone() as IComponentPrototype;
        }
    }
}
