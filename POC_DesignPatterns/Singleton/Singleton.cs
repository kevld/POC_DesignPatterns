namespace POC_DesignPatterns.NS_Singleton;

public sealed class Singleton
{
    private static Singleton? _instance;

    public Guid GeneratedGuid { get; private set; }

    private Singleton()
    {

        GeneratedGuid = Guid.NewGuid();
    }

    public static Singleton GetInstance()
    {
        if (_instance == null)
            _instance = new Singleton();

        return _instance;
    }
}