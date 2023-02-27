namespace Singleton;

public sealed class SafeLazySingleton
{
    private string Name { get; init; }
    private static SafeLazySingleton _instance;

    private static readonly object _lockObject = new object();
    
    private SafeLazySingleton(string name)
    {
        Name = name;
    }

    public static SafeLazySingleton Initialize(string name)
    {
        // Это условие нужно для того, чтобы не стопорить потоки блокировкой
        // после того как объект-одиночка уже создан.
        if (_instance == null)
        {
            // Теперь представьте, что программа была только-только
            // запущена. Объекта-одиночки ещё никто не создавал, поэтому
            // несколько потоков вполне могли одновременно пройти через
            // предыдущее условие и достигнуть блокировки. Самый быстрый
            // поток поставит блокировку и двинется внутрь секции, пока
            // другие будут здесь его ожидать.
            lock (_lockObject)
            {
                // Первый поток достигает этого условия и проходит внутрь,
                // создавая объект-одиночку. Как только этот поток покинет
                // секцию и освободит блокировку, следующий поток может
                // снова установить блокировку и зайти внутрь. Однако теперь
                // экземпляр одиночки уже будет создан и поток не сможет
                // пройти через это условие, а значит новый объект не будет
                // создан.
                if (_instance == null)
                {
                    _instance = new SafeLazySingleton(name);
                }
            }
        }

        return _instance;
    }
    
    public override string ToString()
    {
        return $"Singleton name is {Name}";
    }
}