namespace GO4.NET.Console._2_Structural._3_Composite
{
    public abstract class Component
    {
        protected Component(string name, float x, float y)
        {
            Name = name;
            X = x;
            Y = y;
        }

        public string Name { get; set; }
        public float X { get; set; }
        public float Y { get; set; }
        public abstract void Add(Component component);
        public abstract void Remove(Component component);
        public abstract void Show();
    }
}
