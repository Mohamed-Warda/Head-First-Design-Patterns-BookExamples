namespace ObserverPattern.WeatherStationExample;

public class WeatherData : ISubject
{
    private readonly List<IObserver> _observers;
    public float Humidity { get; private set; } 
    public float Pressure { get; private set; } 
    public float Temperature { get; private set; } 
    public WeatherData()
    {
        _observers = new List<IObserver>();
    }

    public void RegisterObserver(IObserver observer)
    {
        _observers.Add(observer);
    }

    public void RemoveObserver(IObserver observer)
    {
        _observers.Remove(observer);
    }

    public void NotifyObserver()
    {
        foreach (var observer in _observers)
        {
            observer.Update();
        }
    }

    private void MeasurementsChanged()
    {
        NotifyObserver();
    }

    public void SetMeasurements(float temperature, float humidity, float pressure)
    {
        Temperature = temperature;
        Humidity = humidity;
        Pressure = pressure;
        MeasurementsChanged();
    }
}