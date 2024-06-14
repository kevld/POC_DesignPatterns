namespace POC_DesignPatterns.FactoryMethod;

public abstract class Creator
{
    public abstract IColor FactoryColorMethod();

    public string RandomString()
    {
        var factory = FactoryColorMethod();
        return $"Color is {factory.GetColor()}";
    }
}