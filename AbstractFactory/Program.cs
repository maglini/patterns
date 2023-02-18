using AbstractFactory.Factories;

namespace AbstractFactory;

internal class Program
{
    static void Main(string[] args)
    {
        var factory = new USADollsFactory();

        var barbie = factory.CreateBarbie(name: "Olivia", hair: "Blond long hair");
        var ken = factory.CreateKen(name: "Kel", smile: "White smile");
    }
}