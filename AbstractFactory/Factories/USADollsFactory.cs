using AbstractFactory.Entries;

namespace AbstractFactory.Factories;

public class USADollsFactory : AbstractDollsFactory
{
    public override IBarbie CreateBarbie(string name, string hair)
        => new Barbie() {Name = name, Hair = hair};

    public override IKen CreateKen(string name, string smile)
        => new Ken() {Name = name, Smile = smile};
}