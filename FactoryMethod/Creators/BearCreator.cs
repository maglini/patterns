using FactoryMethod.Entries;

namespace FactoryMethod.Creators;

public class BearCreator : ToyCreator
{
    public override IToy Create() => new Bear();
}