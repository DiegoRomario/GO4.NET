namespace GO4.NET.Console._3_Behavioral._6_Memento
{
    public interface ICalculator
    {
        ICareTaker BackupLastCalculation();

        void RestoreLastCalculation(ICareTaker memento);

        int GetResult();
        void SetFirstNumber(int num1);
        void SetSecondNumber(int num2);
    }
}
