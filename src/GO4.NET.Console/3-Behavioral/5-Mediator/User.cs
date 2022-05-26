namespace GO4.NET.Console._3_Behavioral._5_Mediator
{
    public abstract class User
    {
        protected IFacebookGroupMediator mediator;
        protected string name;

        public User(IFacebookGroupMediator mediator, string name)
        {
            this.mediator = mediator;
            this.name = name;
        }

        public abstract void Send(string message);
        public abstract void ReceiveMessage(string message);
    }
}
