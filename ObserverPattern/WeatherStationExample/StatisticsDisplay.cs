namespace ObserverPattern.WeatherStationExample;

public class StatisticsDisplay : IObserver, IDisplayElement
{
    private readonly WeatherData _weatherData;
    private float _maxTemp = 0.0f;
    private float _minTemp = 200.0f;
    private float _tempSum = 0.0f;
    private int _numReadings;

    public StatisticsDisplay(WeatherData weatherData)
    {
        _weatherData = weatherData;
        weatherData.RegisterObserver(this);
    }

    public void Update()
    {
      var  temp = _weatherData.Temperature;
        _tempSum +=temp ;
        _numReadings++;

        if (temp > _maxTemp)
        {
            _maxTemp = temp;
        }

        if (temp < _minTemp)
        {
            _minTemp = temp;
        }

        Display();
    }

    public void Display()
    {
        Console.WriteLine("Avg/Max/Min temperature = " 
                          + (_tempSum / _numReadings).ToString("F2") + "/"  // Format average to 2 decimal places
                          + _maxTemp.ToString("F2") + "/"   
                          + _minTemp.ToString("F2"));  
    }
}