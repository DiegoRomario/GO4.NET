using static System.Console;

namespace GO4.NET.Console._3_Behavioral._1_ChainOfResponsibility.ConcreteImplementations
{
    public class HRManager : AuthorizedPerson
    {
        private const int AMOUNT_DAYS_ALLOWED = 30;
        public override void AuthorizePaidTimeOff(string name, int amountDays)
        {
            if (amountDays <= AMOUNT_DAYS_ALLOWED)
                AproveLicence(name, amountDays);
            else
                WriteLine($"Could not authorize days of paid time off for {amountDays} days for {name}.");
        }

        private void AproveLicence(string name, int amountDays) =>
            WriteLine($"The HR manger has approved {amountDays} days of paid time off for: {name}");
    }
}
