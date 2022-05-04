namespace GO4.NET.Console._2_Structural._6_Flyweight
{
    public abstract class IFlyweight
    {
        public string Instrinsic { get; set; }
        protected string Extrinsic { get; set; }

        public IFlyweight(string extrinsic)
        {
            this.Extrinsic = extrinsic;
        }
        public abstract void Operate(int id);
    }
}
