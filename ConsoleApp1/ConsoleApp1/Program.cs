using ConsoleApp1.Abstract_Factory;
using ConsoleApp1.Builder;
using ConsoleApp1.Factory_Method;

Console.WriteLine("Input num:");
Console.WriteLine("1. Factory");
Console.WriteLine("2. Abstract Factory");
Console.WriteLine("3. Builder");
//Console.WriteLine("Input num:");
//Console.WriteLine("Input num:");
//Console.WriteLine("Input num:");
//Console.WriteLine("Input num:");
//Console.WriteLine("Input num:");
//Console.WriteLine("Input num:");
//Console.WriteLine("Input num:");
//Console.WriteLine("Input num:");
Console.WriteLine();

int a = 0;
int.TryParse(Console.ReadLine(), out a);

switch (a)
{
    case 1:
        IWorkShop creator = new CarWorkShop();
        creator.Create();
        creator = new TruckWorkShop();
        creator.Create();
        break;
    case 2:
        IFactory factory = new JapaniceFactory();
        IEngine engine = factory.CreateEngine();
        ICar car = factory.CreateCar();
        car.ReleaseCar(engine);

        Console.WriteLine();

        factory = new AmericanFactory();
        engine = factory.CreateEngine();
        car = factory.CreateCar();
        car.ReleaseCar(engine);
        break;
    case 3:
        IDeveloper androidDeveloper = new AndroidDeveloper();

        Director director = new Director(androidDeveloper);
        Phone samsung = director.MountFullPhone();
        Console.WriteLine(samsung.AboutPhone());

        IDeveloper iphoneDeveloper = new IphoneDeveloper();
        director = new Director(iphoneDeveloper);
        Phone iphone = director.MountOnlyPhone();
        Console.WriteLine(iphone.AboutPhone());
        break;
}