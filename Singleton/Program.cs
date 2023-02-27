namespace Singleton;

internal class Program
{
    static void Main(string[] args)
    {
        // // output is Foo
        // var s1 = UnsafeSingleton.Initialize("Foo");
        // var s2 = UnsafeSingleton.Initialize("Bar");
        // Console.WriteLine(s1);
        // Console.WriteLine(s2);
        //
        // output is foo and bar 
        var thread1 = new Thread(() => TestUnsafeSingleton("Foo"));
        var thread2 = new Thread(() => TestUnsafeSingleton("Bar"));
        thread1.Start();
        thread2.Start();
        thread1.Join();
        thread2.Join();
        
        // // output is bar 
        // var thread3 = new Thread(() => TestingSafeSingleton("Bar"));
        // var thread4 = new Thread(() => TestingSafeSingleton("Foo"));
        // thread3.Start();
        // thread4.Start();
        // thread3.Join();
        // thread4.Join();

    }

    private static void TestUnsafeSingleton(string value)
    {
        var singleton = UnsafeLazySingleton.Initialize(value);
        Console.WriteLine(singleton);
    }

    private static void TestingSafeSingleton(string value)
    {
        var singleton = SafeLazySingleton.Initialize(value);
        Console.WriteLine(singleton);
    }
}