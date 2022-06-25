using static System.Console;
namespace GO4.NET.Console._3_Behavioral._8_State.ConcreteImplementations
{
    public class Account
    {
        private State state;
        private string owner;
        public Account(string owner)
        {
            this.owner = owner;
            this.state = new SilverState(0.0, this);
        }
        public double Balance
        {
            get { return state.Balance; }
        }
        public State State
        {
            get { return state; }
            set { state = value; }
        }
        public void Deposit(double amount)
        {
            state.Deposit(amount);
            WriteLine("Deposited {0:C} --- ", amount);
            WriteLine(" Balance = {0:C}", this.Balance);
            WriteLine(" Status  = {0}",
                this.State.GetType().Name);
            WriteLine("");
        }
        public void Withdraw(double amount)
        {
            state.Withdraw(amount);
            WriteLine("Withdrew {0:C} --- ", amount);
            WriteLine(" Balance = {0:C}", this.Balance);
            WriteLine(" Status  = {0}\n",
                this.State.GetType().Name);
        }
        public void PayInterest()
        {
            state.PayInterest();
            WriteLine("Interest Paid --- ");
            WriteLine(" Balance = {0:C}", this.Balance);
            WriteLine(" Status  = {0}\n",
                this.State.GetType().Name);
        }
    }
}
