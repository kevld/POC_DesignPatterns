namespace POC_DesignPatterns.Builder;

public class BuilderLauncher
{
    public void Launch()
    {
        var director = new ShapeDirector();
        var builder = new ShapeBuilder();
        director.ShapeBuilder = builder;

        Console.WriteLine("Building shape :");
        director.BuildShape();
        Console.WriteLine(builder.Build().GetResult());
        Console.WriteLine("Building shape with color:");
        director.BuildShapeWithColor();
        Console.WriteLine($"Result : {builder.Build().GetResult()}");
        Console.WriteLine("Building shape with texture:");
        director.BuildShapeWithTexture();
        Console.WriteLine($"Result : {builder.Build().GetResult()}");
        Console.WriteLine("Building shape with color and texture:");
        director.BuildFullShape();
        Console.WriteLine($"Result : {builder.Build().GetResult()}");

        Console.WriteLine("Without director :");
        Console.WriteLine("Shape :");
        builder.CreateShape();
        Console.WriteLine($"Result : {builder.Build().GetResult()}");
        Console.WriteLine("Shape + Color :");
        builder.CreateShape();
        builder.WithColor();
        Console.WriteLine($"Result : {builder.Build().GetResult()}");
        Console.WriteLine("Shape + Texture :");
        builder.CreateShape();
        builder.WithTexture();
        Console.WriteLine($"Result : {builder.Build().GetResult()}");
        Console.WriteLine("Shape + Color + Texture :");
        builder.CreateShape();
        builder.WithColor();
        builder.WithTexture();
        Console.WriteLine($"Result : {builder.Build().GetResult()}");
    }
}