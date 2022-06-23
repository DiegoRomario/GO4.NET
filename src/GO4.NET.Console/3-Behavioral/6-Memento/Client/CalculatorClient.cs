using static System.Console;
using GO4.NET.Console._3_Behavioral._6_Memento.ConcreteImplementations;

namespace GO4.NET.Console._3_Behavioral._6_Memento.Client
{
    public static class CalculatorClient
    {
        public static void Calculate()
        {
            var calculator = new Calculator();
            calculator.SetFirstNumber(10);
            calculator.SetSecondNumber(100);

            WriteLine($"1º Operation: {calculator.GetResult()}");

            ICareTaker memento = calculator.BackupLastCalculation();

            calculator.SetFirstNumber(17);
            calculator.SetSecondNumber(-290);

            WriteLine($"2º Operation:{calculator.GetResult()}");

            calculator.RestoreLastCalculation(memento);

            WriteLine($"Restoring 1º operation: {calculator.GetResult()}");
        }
    }
}
