namespace ObserverPattern.SimpleObservableExample;

public class Observer:IObserver
{
    public void Update()
    {
        Console.WriteLine($"{nameof(Observer)} is Updated");
    }
}