namespace GO4.NET.Console._3_Behavioral._6_Memento.ConcreteImplementations
{
    public class Calculator : ICalculator
    {
        private int firstNumber;
        private int secondNumber;
        public ICareTaker BackupLastCalculation() => new CalculatorMemento(firstNumber, secondNumber);

        public int GetResult() => firstNumber + secondNumber;

        public void RestoreLastCalculation(ICareTaker memento)
        {
            firstNumber = ((IRestoreCalculation)memento).GetFirstNumber();
            secondNumber = ((IRestoreCalculation)memento).GetSecondNumber();
        }

        public void SetFirstNumber(int num1) => firstNumber = num1;

        public void SetSecondNumber(int num2) => secondNumber = num2;
    }
}
