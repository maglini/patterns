using FactoryMethod.Creators;
using FactoryMethod.Entries;

namespace FactoryMethod;

internal class Program
{
    static void Main(string[] args)
    {
        var dollCreator = new DollCreator();
        var bearCreator = new BearCreator();

        var toys = new List<IToy>();
        toys.Add(dollCreator.Create());
        toys.Add(dollCreator.Create());
        toys.Add(bearCreator.Create());
        
        foreach (var toy in toys)
        {
            Console.WriteLine(toy.Play());
        }
    }
}