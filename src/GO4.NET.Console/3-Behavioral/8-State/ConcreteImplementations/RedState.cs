using static System.Console;
namespace GO4.NET.Console._3_Behavioral._8_State.ConcreteImplementations
{
    public class RedState : State
    {
        private double serviceFee;
        public RedState(State state)
        {
            this.balance = state.Balance;
            this.account = state.Account;
            Initialize();
        }
        private void Initialize()
        {
            interest = 0.0;
            lowerLimit = -100.0;
            upperLimit = 0.0;
            serviceFee = 15.00;
        }
        public override void Deposit(double amount)
        {
            balance += amount;
            StateChangeCheck();
        }
        public override void Withdraw(double amount)
        {
            amount = amount - serviceFee;
            WriteLine("No funds available for withdrawal!");
        }
        public override void PayInterest()
        {
            // No interest is paid
        }
        private void StateChangeCheck()
        {
            if (balance > upperLimit)
            {
                account.State = new SilverState(this);
            }
        }
    }
}
