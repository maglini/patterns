using FactoryMethod.Entries;

namespace FactoryMethod.Creators;

public abstract class ToyCreator
{
    public abstract IToy Create();
}