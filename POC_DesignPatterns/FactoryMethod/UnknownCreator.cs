namespace POC_DesignPatterns.FactoryMethod;

public class UnknownCreator : Creator
{
    public override IColor FactoryColorMethod()
    {
        return new UnknownColor();
    }
}