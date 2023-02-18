using AbstractFactory.Entries;

namespace AbstractFactory.Factories;

public abstract class AbstractDollsFactory
{
    public abstract IBarbie CreateBarbie(string name, string hair);

    public abstract IKen CreateKen(string name, string smile);
}