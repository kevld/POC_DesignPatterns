namespace POC_DesignPatterns.FactoryMethod;

public class FactoryMethodLauncher
{
    public void Launch()
    {
        Console.WriteLine("Launching Green");
        CreateInstance(new GreenCreator());

        Console.WriteLine("");

        Console.WriteLine("Launching Blue");
        CreateInstance(new BlueCreator());

        Console.WriteLine("");

        Console.WriteLine("Launching ???");
        CreateInstance(new UnknownCreator());
    }

    private void CreateInstance(Creator creator)
    {
        try
        {
            Console.WriteLine($"Launched {creator.FactoryColorMethod().GetColor()}");
        }
        catch (System.Exception)
        {
            Console.WriteLine($"Failed to launch {creator.GetType()}");
        }
    }
}