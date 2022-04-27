namespace GO4.NET.Console._2_Structural._4_Decorator
{
    public interface IMenu
    {
        IEnumerable<IMenuItem> Items { get; }
    }
}
