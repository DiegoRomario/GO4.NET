using GO4.NET.Console._3_Behavioral._5_Mediator.ConcreteImplementations;

namespace GO4.NET.Console._3_Behavioral._5_Mediator.Client
{
    internal class MediatorClient
    {
        public static void Run()
        {
            IFacebookGroupMediator facebookGroupMediator = new ConcreteFacebookMediator();

            User joey = new ConcreteUser(facebookGroupMediator, "Joey");
            User deedee = new ConcreteUser(facebookGroupMediator, "DeeDee");
            User johnny = new ConcreteUser(facebookGroupMediator, "Johnny");
            User tommy = new ConcreteUser(facebookGroupMediator, "Tommy");

            facebookGroupMediator.RegisterUser(joey);
            facebookGroupMediator.RegisterUser(deedee);
            facebookGroupMediator.RegisterUser(johnny);
            facebookGroupMediator.RegisterUser(tommy);

            joey.Send("Where can I find Ramones albums?");
            tommy.Send("Spotify!");
            joey.Send("Thank you!");
        }
    }
}
