namespace ChainOfResponsibility;

public class Program
{
    static void Main(string[] args)
    {
        var pie = new Pie(Filling.Apple, 100);

        var tiger1 = new Tiger();
        var monkey1 = new Monkey();
        var fish1 = new Fish();
        var tiger2 = new Tiger();
        var tiger3 = new Tiger();
        var tiger4 = new Tiger();
        var tiger5 = new Tiger();
        var tiger6 = new Tiger();
        var tiger7 = new Tiger();

        tiger1
            .SetNext(monkey1)
            .SetNext(fish1)
            .SetNext(tiger2)
            .SetNext(tiger3)
            .SetNext(tiger4)
            .SetNext(tiger5)
            .SetNext(tiger6)
            .SetNext(tiger7);

        var restPie = tiger1.Handle(pie);
        
        Console.WriteLine(restPie);
    } 
}