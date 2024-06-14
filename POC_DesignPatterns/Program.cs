// See https://aka.ms/new-console-template for more information

using POC_DesignPatterns.FactoryMethod;
using POC_DesignPatterns.NS_Singleton;

Console.WriteLine("Singleton :");

Singleton s1 = Singleton.GetInstance();
Singleton s2 = Singleton.GetInstance();

Console.WriteLine($"s1 Guid : {s1.GeneratedGuid}");
Console.WriteLine($"s2 Guid : {s2.GeneratedGuid}");

Console.WriteLine("=======================================");
Console.WriteLine("");
Console.WriteLine("Factory method :");

var fml = new FactoryMethodLauncher();
fml.Launch();

Console.ReadKey();