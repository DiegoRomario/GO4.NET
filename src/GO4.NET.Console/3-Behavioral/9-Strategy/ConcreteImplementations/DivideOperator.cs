
namespace GO4.NET.Console._3_Behavioral._9_Strategy.ConcreteImplementations
{
    public class DivideOperator : IMathOperator
    {
        public EOperator Operator => EOperator.Divide;

        public int Calculate(int number1, int number2)
        {
            if (number2 == 0)
                throw new DivideByZeroException();

            return number1 / number2;
        }
    }
}
