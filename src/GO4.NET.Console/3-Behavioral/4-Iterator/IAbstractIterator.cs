using GO4.NET.Console._3_Behavioral._4_Iterator.ConcreteImplementations;

namespace GO4.NET.Console._3_Behavioral._4_Iterator
{
    public interface IAbstractIterator
    {
        User First();
        User Next();
        bool IsDone { get; }
    }
}
