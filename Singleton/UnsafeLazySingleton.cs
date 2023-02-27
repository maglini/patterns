namespace Singleton;

public sealed class UnsafeLazySingleton
{
    private string Name { get; init; }
    
    private static UnsafeLazySingleton _instance;
    
    private UnsafeLazySingleton(string name)
    {
        Name = name;
    }

    public static UnsafeLazySingleton Initialize(string name)
    {
        if (_instance == null)
        {
            _instance = new UnsafeLazySingleton(name);
        }
        
        return _instance;
    }

    public override string ToString()
    {
        return $"Singleton name is {Name}";
    }
}