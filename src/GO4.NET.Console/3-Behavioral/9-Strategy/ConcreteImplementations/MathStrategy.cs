namespace GO4.NET.Console._3_Behavioral._9_Strategy.ConcreteImplementations
{
    public class MathStrategy : IMathStrategy
    {
        private readonly IEnumerable<IMathOperator> _operators;

        public MathStrategy(IEnumerable<IMathOperator> operators)
        {
            _operators = operators;
        }

        public int Calculate(int number1, int number2, EOperator @operator)
        {
            return _operators.FirstOrDefault(x => x.Operator == @operator)?.Calculate(number1, number2)
                    ?? throw new ArgumentNullException(nameof(@operator));
        }
    }
}
