namespace POC_DesignPatterns.FactoryMethod;

public class UnknownColor : IColor
{
    public string GetColor()
    {
        throw new NotImplementedException();
    }
}