namespace Singleton;

public class SecondSafeLazyLoadingSingleton
{
    public static SecondSafeLazyLoadingSingleton _instance;
    public string Name;

    private static readonly object lockObject;
        
    public static SecondSafeLazyLoadingSingleton Initialize(string name)
    {
        lock (lockObject)
        {
            if (_instance == null)
            {
                return new SecondSafeLazyLoadingSingleton();
            }

            return _instance;
        }
    }
}