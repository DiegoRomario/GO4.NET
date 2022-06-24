namespace GO4.NET.Console._3_Behavioral._7_Observer.ConcreteImplementations
{
    public class WeatherStation : ISubject
    {
        private readonly List<IObserver> _observers;
        private float _temperature;

        public float Temperature
        {
            get { return _temperature; }
            set
            {
                _temperature = value;
                Notify();
            }
        }
        public WeatherStation() => _observers = new List<IObserver>();

        public void Attach(IObserver observer) => _observers.Add(observer);
        public void Detach(IObserver observer) => _observers.Remove(observer);

        public void Notify()
        {
            _observers.ForEach(o =>
            {
                o.Update(this);
            });
        }
    }

}
