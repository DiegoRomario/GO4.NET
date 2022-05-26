namespace GO4.NET.Console._3_Behavioral._5_Mediator.ConcreteImplementations
{
    public class ConcreteFacebookMediator : IFacebookGroupMediator
    {
        private readonly List<User> userList = new();
        public void RegisterUser(User user)
        {
            userList.Add(user);
        }

        public void SendMessage(string msg, User user)
        {
            foreach (var u in userList)
            {
                if (u != user) u.ReceiveMessage(msg);
            }
        }
    }
}
