namespace GO4.NET.Console._3_Behavioral._5_Mediator
{
    public interface IFacebookGroupMediator
    {
        void SendMessage(string msg, User user);
        void RegisterUser(User user);
    }
}
