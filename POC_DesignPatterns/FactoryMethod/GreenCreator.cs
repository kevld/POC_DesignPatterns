namespace POC_DesignPatterns.FactoryMethod;

public class GreenCreator : Creator
{
    public override IColor FactoryColorMethod()
    {
        return new GreenColor();
    }
}