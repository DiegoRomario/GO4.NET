using GO4.NET.Console._3_Behavioral._8_State.ConcreteImplementations;

namespace GO4.NET.Console._3_Behavioral._8_State.Client
{
    public static class StateClient
    {
        public static void Pay()
        {
            Account account = new("Mark Ramone");
            account.Deposit(500.0);
            account.Deposit(300.0);
            account.Deposit(550.0);
            account.PayInterest();
            account.Withdraw(2000.00);
            account.Withdraw(1100.00);
            account.Deposit(1000.0);
            account.Withdraw(100.00);
            account.Deposit(5000.0);
        }
    }
}
