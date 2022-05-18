
using GO4.NET.Console._3_Behavioral._1_ChainOfResponsibility.ConcreteImplementations;

namespace GO4.NET.Console._3_Behavioral._1_ChainOfResponsibility.Client
{
    public static class AuthorizationClient
    {
        public static void AuthorizePaidTimeOff()
        {
            ProjectManager projectManager = new();
            TeamLeader teamLeader = new();
            HRManager hRManager = new();

            projectManager.NextAuthorizedPerson(teamLeader);
            teamLeader.NextAuthorizedPerson(hRManager);

            projectManager.AuthorizePaidTimeOff("Rogério", 4);
            projectManager.AuthorizePaidTimeOff("Danilo", 13);
            projectManager.AuthorizePaidTimeOff("Aloísio", 22);
            projectManager.AuthorizePaidTimeOff("Josué", 60);
        }
    }
}
