namespace POC_DesignPatterns.FactoryMethod;

public class BlueCreator : Creator
{
    public override IColor FactoryColorMethod()
    {
        return new BlueColor();
    }
}