using GO4.NET.Console._3_Behavioral._7_Observer.ConcreteImplementations;

namespace GO4.NET.Console._3_Behavioral._7_Observer.Client
{
    public static class ObserverClient
    {
        public static void Observe()
        {
            WeatherStation weatherStation = new();

            NewsAgency onlyNews = new("Only News");
            weatherStation.Attach(onlyNews);

            weatherStation.Temperature = 24.2f;

            NewsAgency bestNews = new NewsAgency("Best News");
            weatherStation.Attach(bestNews);

            weatherStation.Temperature = 12.8f;
            weatherStation.Temperature = 15.8f;
            weatherStation.Detach(bestNews);
            weatherStation.Temperature = 35.2f;
        }
    }
}
