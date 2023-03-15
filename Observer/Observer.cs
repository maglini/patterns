namespace Observer;

public interface IObserver
{
    public string Name { get; init; }
    void Update(ISubject subject);
}

public class ConcreteObserverA: IObserver
{
    public string Name { get; init; }

    public ConcreteObserverA(string name)
    {
        Name = name;
    }
    
    public void Update(ISubject subject)
    {
        Console.WriteLine($"Customer {Name} known about new state: {subject.State}");
    }
}

public class ConcreteObserverB : IObserver
{
    public string Name { get; init; }

    public ConcreteObserverB(string name)
    {
        Name = name;
    }
    
    public void Update(ISubject subject)
    {
        Console.WriteLine($"Customer {Name} known about new state: {subject.State}");
    }
}