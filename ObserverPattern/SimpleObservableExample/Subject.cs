namespace ObserverPattern.SimpleObservableExample;

public class Subject : ISubject
{
    private List<IObserver> _observers;
    private bool isActive;

    public Subject()
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

    public bool GetState()
    {
        return isActive;
    }
    public void SetState(bool state)
    {
         isActive = state;
         NotifyObserver();
    }
    
}