namespace Singleton;

public class NETSafeLazySingleton
{
    private static readonly Lazy<NETSafeLazySingleton> _lazy =
        new Lazy<NETSafeLazySingleton>(() => new NETSafeLazySingleton());
    
    public static NETSafeLazySingleton Instance
    {
        get => _lazy.Value;
    }
}