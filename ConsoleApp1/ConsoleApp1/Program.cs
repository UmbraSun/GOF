using GOF_Patterns.Abstract_Factory;
using GOF_Patterns.Adapter;
using GOF_Patterns.Builder;
using GOF_Patterns.Factory_Method;
using GOF_Patterns.Prototype;
using GOF_Patterns.Singleton;

Console.WriteLine("Input num:");
Console.WriteLine("1. Factory");
Console.WriteLine("2. Abstract Factory");
Console.WriteLine("3. Builder");
Console.WriteLine("4. Singleton");
Console.WriteLine("5. Prototype");
Console.WriteLine("6. Adapter");
//Console.WriteLine("Input num:");
//Console.WriteLine("Input num:");
//Console.WriteLine("Input num:");
//Console.WriteLine("Input num:");
//Console.WriteLine("Input num:");
Console.WriteLine();

int a = 0;
int.TryParse(Console.ReadLine(), out a);
Console.WriteLine();

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
    case 4:
        DatabaseHelper.GetConnection().InsertData("123");
        Console.WriteLine("Data from DB " + DatabaseHelper.GetConnection().SelectData());
        break;
    case 5:
        IAnimal sheepDonor = new Sheep();
        sheepDonor.SetName("Dolly");

        IAnimal sheepClone = sheepDonor.Clone();

        Console.WriteLine(sheepDonor.GetName());
        Console.WriteLine(sheepClone.GetName());
        break;
    case 6:
        float kg = 55.0f; // kilo
        float lb = 55.0f; // libra

        IScales scales = new OtherScales(kg);
        IScales aScales = new AdapterForAmericanScales(new AmericanScales(lb));

        Console.WriteLine(scales.GetWeight());
        Console.WriteLine(aScales.GetWeight());
        break;
}