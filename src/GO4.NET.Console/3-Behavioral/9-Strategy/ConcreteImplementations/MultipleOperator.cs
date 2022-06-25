
namespace GO4.NET.Console._3_Behavioral._9_Strategy.ConcreteImplementations
{
    public class MultipleOperator : IMathOperator
    {
        public EOperator Operator => EOperator.Multiple;

        public int Calculate(int number1, int number2) => number1 * number2;
    }
}
