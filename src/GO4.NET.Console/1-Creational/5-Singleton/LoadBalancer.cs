using static System.Console;
namespace GO4.NET.Console._1_Creational._5_Singleton
{
    public sealed class LoadBalancer
    {
        private LoadBalancer() { }

        private static LoadBalancer intance;

        public static LoadBalancer GetLoadBalancer()
        {
            if (intance == null)
                intance = new LoadBalancer();

            return intance;
        }

        public void Ping(List<string> brokers, string requestJson)
        {
            Random rnd = new Random();
            WriteLine($"Sending request [{requestJson}] to Server: + {brokers[rnd.Next(brokers.Count)]}");
        }
    }
}
