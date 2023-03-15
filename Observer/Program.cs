namespace Observer;

internal class Program
{
    static void Main(string[] args)
    {
        var store = new Subject();
        var customer1 = new ConcreteObserverA("Valentin");
        var customer2 = new ConcreteObserverB("Boris");
        var customer3 = new ConcreteObserverB("Katherine");
        
        store.Attach(customer1);
        store.Attach(customer2);
        store.Attach(customer3);

        store.State = 5;
        
        store.Detach(customer2);

        store.State = 4;
    } 
}