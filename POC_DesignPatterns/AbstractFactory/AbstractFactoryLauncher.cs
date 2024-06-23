using POC_DesignPatterns.Common;

namespace POC_DesignPatterns.AbstractFactory;

public class AbstractFactoryLauncher : Launcher
{
    public override void Launch()
    {
        Console.WriteLine("Launching Green Circle Factory");
        CreateInstance(new GreenCircleFactory());

        Console.WriteLine("");

        Console.WriteLine("Launching Blue Rectangle Factory");
        CreateInstance(new BlueRectangleFactory());

        Console.WriteLine("");
    }

    private void CreateInstance(IAbstractFactory abstractFactory)
    {
            Console.WriteLine("Create color :");
            IColor color = abstractFactory.CreateColor();
            Console.WriteLine($"Created {color.GetColor()}");

            Console.WriteLine("Create shape :");
            IShape shape = abstractFactory.CreateShape();
            Console.WriteLine($"Created {shape.GetShape()}");
    }
}