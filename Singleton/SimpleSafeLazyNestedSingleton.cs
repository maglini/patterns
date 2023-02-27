namespace Singleton;

public class SimpleSafeLazyNestedSingleton
{
    public static SimpleSafeLazyNestedSingleton Instance
    {
        get => Nested._instance;
    }
    
    private class Nested
    {
        internal static readonly SimpleSafeLazyNestedSingleton _instance = new SimpleSafeLazyNestedSingleton();
    }
}