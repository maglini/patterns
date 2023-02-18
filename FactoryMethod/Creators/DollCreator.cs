using FactoryMethod.Entries;

namespace FactoryMethod.Creators;

public class DollCreator : ToyCreator
{
    public override IToy Create() => new Doll();
}