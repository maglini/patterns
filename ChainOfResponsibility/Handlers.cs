namespace ChainOfResponsibility;

public enum Filling
{
    Apple,
    Cherry,
    Chocolate
}

public class Pie
{
    public Filling Filling { get; init; }
    public double Rest { get; set; }

    public Pie(Filling filling, double rest)
    {
        Filling = filling;
        Rest = rest;
    }

    public override string ToString()
    {
        return $"Filling is {Filling} and Rest is {Rest}";
    }
}


public interface IHandler
{
    IHandler SetNext(IHandler handler);
    public Pie Handle(Pie pie);
}

public abstract class AbstractHandler : IHandler
{
    public Filling FavoriteFilling { get; init; }
    public double FavoritePortion { get; init; }

    private IHandler _next;
    protected AbstractHandler(Filling favoriteFilling, double favoritePortion)
    {
        FavoriteFilling = favoriteFilling;
        FavoritePortion = favoritePortion;
        
    }
    public IHandler SetNext(IHandler handler)
    {
        _next = handler;
        return _next;
    }

    public Pie Handle(Pie pie)
    {
        if (pie.Rest <= 0)
        {
            return pie;
        }

        if (FavoriteFilling == pie.Filling)
        {
            pie.Rest -= FavoritePortion;
        }

        return (_next != null) ? _next.Handle(pie) : pie;
    }
}

public class Tiger : AbstractHandler
{
    public Tiger() : base(Filling.Apple, 20)
    {
    }
}

public class Monkey : AbstractHandler
{
    public Monkey() : base(Filling.Cherry, 10)
    {
    }
}

public class Fish : AbstractHandler
{
    public Fish() : base(Filling.Chocolate, 5)
    {
    }
}