namespace Prototype;

internal class Program
{
    static void Main(string[] args)
    {
        var cat1 = new Cat() {Name = "Barsik", IsEatFish = true, Toy = new Toy() {Name = "Ball"}};
        Console.WriteLine("Cat1 info: " + cat1);
        var cat2 = cat1.ShallowCopy();
        Console.WriteLine("Cat2 info: " + cat2);
        var cat3 = cat1.DeepCopy();
        Console.WriteLine("Cat3 info: " + cat2);
        
        cat1.Name = "Vasek";
        cat1.Toy.Name = "Bird";
        Console.WriteLine("Changed name and toy:");
        Console.WriteLine("Cat1 info: " + cat1);
        Console.WriteLine("Cat2 info: " + cat2);
        Console.WriteLine("Cat3 info: " + cat3);
    }
}