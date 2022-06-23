namespace GO4.NET.Console._3_Behavioral._6_Memento.ConcreteImplementations
{
    public class CalculatorMemento : ICareTaker, IRestoreCalculation
    {
        private readonly int firstNumber;
        private readonly int secondNumber;

        public CalculatorMemento(int num1, int num2)
        {
            firstNumber = num1;
            secondNumber = num2;
        }

        public int GetFirstNumber()
        {
            return firstNumber;
        }

        public int GetSecondNumber()
        {
            return secondNumber;
        }
    }
}
