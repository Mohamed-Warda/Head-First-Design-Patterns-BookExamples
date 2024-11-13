namespace ObserverPattern.WeatherStationExample;

public class CurrentConditionsDisplay : IObserver, IDisplayElement
{
    private readonly WeatherData _weatherData;
    private float _humidity;
    private float _temperature;

    public CurrentConditionsDisplay(WeatherData weatherData)
    {
        _weatherData = weatherData;
        weatherData.RegisterObserver(this);
    }

    public void Display()
    {
        Console.WriteLine($"Current conditions: {_temperature}F degrees and {_humidity}% humidity");
    }

    public void Update()
    {
        _temperature = _weatherData.Temperature;
        _humidity = _weatherData.Humidity;
        Display();
    }
}