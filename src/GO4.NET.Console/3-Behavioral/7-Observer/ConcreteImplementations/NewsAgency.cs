using static System.Console;

namespace GO4.NET.Console._3_Behavioral._7_Observer.ConcreteImplementations
{
    public class NewsAgency : IObserver
    {
        public string AgencyName { get; set; }
        public NewsAgency(string name) => AgencyName = name;

        public void Update(ISubject subject)
        {
            if (subject is WeatherStation weatherStation)
                WriteLine($"{AgencyName} reporting temperature {weatherStation.Temperature} degree celcius");

        }

    }
}
