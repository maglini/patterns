namespace Observer;

public interface ISubject
{
    public int State { get; set; }
    void Attach(IObserver observer);
    void Detach(IObserver observer);
    void Notify();
}

public class Subject : ISubject
{
    private int _state;

    public int State
    {
        get => _state;
        set
        {
            _state = value;
            Notify();
        }
    }

    private ICollection<IObserver> _observers { get; } = new List<IObserver>();
    
    public void Attach(IObserver observer)
    {
        _observers.Add(observer);
    }

    public void Detach(IObserver observer)
    {
        _observers.Remove(observer);
    }

    public void Notify()
    {
        foreach (var observer in _observers)
        {
            observer.Update(this);
        }
    }
}