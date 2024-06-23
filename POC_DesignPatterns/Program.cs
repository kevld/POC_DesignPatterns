// See https://aka.ms/new-console-template for more information

using POC_DesignPatterns.AbstractFactory;
using POC_DesignPatterns.Adapter;
using POC_DesignPatterns.Builder;
using POC_DesignPatterns.Decorator;
using POC_DesignPatterns.FactoryMethod;
using POC_DesignPatterns.NS_Singleton;
using POC_DesignPatterns.Prototype;

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

Console.WriteLine("=======================================");
Console.WriteLine("");
Console.WriteLine("Factory abstract :");

var avl = new AbstractFactoryLauncher();
avl.Launch();

Console.WriteLine("=======================================");
Console.WriteLine("");
Console.WriteLine("Builder :");
var bl = new BuilderLauncher();
bl.Launch();

Console.WriteLine("=======================================");
Console.WriteLine("");
Console.WriteLine("Prototype :");
var pl = new PrototypeLauncher();
pl.Launch();

Console.WriteLine("=======================================");
Console.WriteLine("");
Console.WriteLine("Adapter :");
var al = new AdapterLauncher();
al.Launch();


Console.WriteLine("=======================================");
Console.WriteLine("");
Console.WriteLine("Decorator :");
var dl = new DecoratorLauncher();
dl.Launch();

Console.ReadKey();