// See https://aka.ms/new-console-template for more information
using Ducks;

Console.WriteLine("Hello, Duck!");
var manyducks = new List<Duck>() { new MountainDuck(), new CityDuck(), new CloudDuck(), new BorgDuck(), new CrazyDuck(), new LazyDuck() };
foreach (var duck in manyducks)
{
    Console.WriteLine(duck.GetType().Name);
    Console.WriteLine($"--------------------");
    duck.Eat().Fly().Figth().Quack();
    Console.WriteLine($"--------------------");
}