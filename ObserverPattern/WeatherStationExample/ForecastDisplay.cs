namespace ObserverPattern.WeatherStationExample;
public class ForecastDisplay :IObserver,IDisplayElement
{
    private readonly WeatherData _weatherData;
    private float _currentPressure = 29.92f;
    private float _lastPressure;

    public ForecastDisplay(WeatherData weatherData)
    {
        _weatherData = weatherData;
        weatherData.RegisterObserver(this);
    }

    public void Update()
    {
        _lastPressure = _currentPressure;
        _currentPressure = _weatherData.Pressure;
        Display();
    }

    public void Display()
    {
        const float epsilon = 0.0001f; // Small tolerance for floating-point comparison
        Console.Write("Forecast: ");
        if (_currentPressure > _lastPressure)
        {
            Console.WriteLine("Improving weather on the way!");
        }
        else if (Math.Abs(_currentPressure - _lastPressure) < epsilon)
        {
            Console.WriteLine("More of the same");
        }
        else if (_currentPressure < _lastPressure)
        {
            Console.WriteLine("Watch out for cooler, rainy weather");
        }
    }
}