namespace GO4.NET.Console._3_Behavioral._9_Strategy
{
    public interface IMathOperator
    {
        EOperator Operator { get; }

        int Calculate(int number1, int number2);
    }
}
