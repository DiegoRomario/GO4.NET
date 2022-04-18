using static System.Console;
namespace GO4.NET.Console._2_Structural._1_Adapter.Client
{
    public class HomeApplianceClient
    {
        private readonly IConector _conector;
        public string Name { get; set; }

        public HomeApplianceClient(IConector conector, string name)
        {
            _conector = conector;
            Name = name;
        }

        public void TurnOn()
        {
            _conector.Conect();
            WriteLine($"Turning on Appliance: {Name}");
        }

        public void TurnOff()
        {
            WriteLine($"Turning off Appliance: {Name}");
            _conector.Desconect();
        }

        public void Disable()
        {
            WriteLine($"Disabling Appliance: {Name}");
            _conector.Desconect();

        }
    }
}
