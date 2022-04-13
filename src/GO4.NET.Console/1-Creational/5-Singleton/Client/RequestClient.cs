using static System.Console;
namespace GO4.NET.Console._1_Creational._5_Singleton.Client
{
    public static class RequestClient
    {
        public static void Exec()
        {
            var cluster = new List<string>() { "192.127.10.2", "192.127.10.4", "192.127.10.5", "192.127.10.1" };
            var balancer1 = LoadBalancer.GetLoadBalancer();
            var balancer2 = LoadBalancer.GetLoadBalancer();
            var balancer3 = LoadBalancer.GetLoadBalancer();
            var balancer4 = LoadBalancer.GetLoadBalancer();

            if (balancer1 == balancer2 & balancer2 == balancer3 && balancer3 == balancer4) WriteLine("Same instance");

            for (int i = 0; i < 10; i++)
            {
                balancer1.Ping(cluster, "{field: value}");
                Thread.Sleep(1000);
            }
        }
    }
}
