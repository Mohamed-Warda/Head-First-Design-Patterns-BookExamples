using ObserverPattern.SimpleObservableExample;

namespace DesignSharpConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sub = new Subject();
            var obs = new Observer();
            sub.RegisterObserver(obs);
        
            sub.SetState(false);
            sub.RemoveObserver(obs);
            sub.RemoveObserver(obs);
        }
    }
}
