namespace POC_DesignPatterns.AbstractFactory;

public interface IAbstractFactory
{
    IColor CreateColor();

    IShape CreateShape();
}
