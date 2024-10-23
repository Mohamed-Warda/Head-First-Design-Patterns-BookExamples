namespace ObserverPattern.SimpleObservableExample;

public interface ISubject
{
    void RegisterObserver(IObserver observer);
    void RemoveObserver(IObserver observer);
    void NotifyObserver();
    bool GetState();
    void SetState(bool state);
}