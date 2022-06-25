using static System.Console;
using GO4.NET.Console._3_Behavioral._9_Strategy.ConcreteImplementations;

namespace GO4.NET.Console._3_Behavioral._9_Strategy.Client
{
    public static class StrategyClient
    {
        public static void Run()
        {
            var list = new List<IMathOperator>()
            {
                new AddOperator(),
                new DivideOperator(),
                new MultipleOperator(),
                new SubtractOperator(),
            };
            var math = new MathStrategy(list);
            int number1 = 10;
            int number2 = 5;
            var result = math.Calculate(number1, number2, EOperator.Substract);
            WriteLine($"Number1: {number1}");
            WriteLine($"Number2: {number2}");
            WriteLine($"Operation: {EOperator.Substract.ToString()}");
            WriteLine($"Result: {result}");

        }
    }
}
