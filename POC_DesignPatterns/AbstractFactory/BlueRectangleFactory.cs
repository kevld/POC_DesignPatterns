namespace POC_DesignPatterns.AbstractFactory;

public class BlueRectangleFactory : IAbstractFactory
{
    public IColor CreateColor()
    {
        return new BlueColor();
    }

    public IShape CreateShape()
    {
        return new RectangleShape();
    }
}