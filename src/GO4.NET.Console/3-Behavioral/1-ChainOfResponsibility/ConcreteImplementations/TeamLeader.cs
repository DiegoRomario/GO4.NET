using static System.Console;

namespace GO4.NET.Console._3_Behavioral._1_ChainOfResponsibility.ConcreteImplementations
{
    public class TeamLeader : AuthorizedPerson
    {
        private const int AMOUNT_DAYS_ALLOWED = 15;
        public override void AuthorizePaidTimeOff(string name, int amountDays)
        {
            if (amountDays <= AMOUNT_DAYS_ALLOWED)
                AproveLicence(name, amountDays);
            else
                _nextAuthorizedPerson?.AuthorizePaidTimeOff(name, amountDays);
        }

        private void AproveLicence(string name, int amountDays) =>
            WriteLine($"The team leader has approved {amountDays} days of paid time off for: {name}");
    }
}
