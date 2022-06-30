namespace GO4.NET.Console._3_Behavioral._11_Visitor
{
    public abstract class Element
    {
        public abstract void Accept(IVisitor visitor);
    }
}
