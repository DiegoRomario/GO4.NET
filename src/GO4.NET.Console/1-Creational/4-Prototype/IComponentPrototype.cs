namespace GO4.NET.Console._1_Creational._4_Prototype
{
    public abstract class IComponentPrototype
    {
        public string Label { get; set; }
        public string Color { get; set; }
        public abstract void Action();
        public abstract IComponentPrototype Clone();
    }
}
