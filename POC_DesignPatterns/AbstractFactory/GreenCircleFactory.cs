namespace POC_DesignPatterns.AbstractFactory;

public class GreenCircleFactory : IAbstractFactory
{
    public IColor CreateColor()
    {
        return new GreenColor();
    }

    public IShape CreateShape()
    {
        return new CircleShape();
    }
}