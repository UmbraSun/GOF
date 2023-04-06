using GOF_Patterns.Abstract_Factory;
using GOF_Patterns.Adapter;
using GOF_Patterns.Bridge;
using GOF_Patterns.Builder;
using GOF_Patterns.ChainOfResponsibility;
using GOF_Patterns.Command;
using GOF_Patterns.Composite;
using GOF_Patterns.Decorator;
using GOF_Patterns.Facade;
using GOF_Patterns.Factory_Method;
using GOF_Patterns.Flyweight;
using GOF_Patterns.Iterator;
using GOF_Patterns.Mediator;
using GOF_Patterns.Memento;
using GOF_Patterns.Observer;
using GOF_Patterns.Prototype;
using GOF_Patterns.Proxy;
using GOF_Patterns.Singleton;

Console.WriteLine("Input num:");
Console.WriteLine("1. Factory");
Console.WriteLine("2. Abstract Factory");
Console.WriteLine("3. Builder");
Console.WriteLine("4. Singleton");
Console.WriteLine("5. Prototype");
Console.WriteLine("6. Adapter");
Console.WriteLine("7. Bridge");
Console.WriteLine("8. Composite");
Console.WriteLine("9. Decorator");
Console.WriteLine("10. Facade:");
Console.WriteLine("11. Flyeweight:");
Console.WriteLine("12. Proxy:");
Console.WriteLine("13. Chain of responsibility");
Console.WriteLine("14. Command");
Console.WriteLine("15. Iterator");
Console.WriteLine("16. Mediator");
Console.WriteLine("17. Memento");
Console.WriteLine("18. Observer");
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

        GOF_Patterns.Builder.Director director = new GOF_Patterns.Builder.Director(androidDeveloper);
        Phone samsung = director.MountFullPhone();
        Console.WriteLine(samsung.AboutPhone());

        IDeveloper iphoneDeveloper = new IphoneDeveloper();
        director = new GOF_Patterns.Builder.Director(iphoneDeveloper);
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
    case 7:
        Sender sender = new EmailSender(new DatabaseReader());
        sender.Send();

        sender.SetDataReader(new FileReader());
        sender.Send();

        sender = new TelegramBotSender(new DatabaseReader());
        sender.Send();
        break;
    case 8:
        Item file = new DropDownItem("File->");
        Item create = new DropDownItem("Create->");
        Item open = new DropDownItem("Open->");
        Item exit = new ClickableItem("Exit->");

        file.Add(create);
        file.Add(open);
        file.Add(exit);

        Item project = new ClickableItem("Project...");
        Item repository = new ClickableItem("Repository...");

        create.Add(project);
        create.Add(repository);

        Item solution = new ClickableItem("Solution...");
        Item folder = new ClickableItem("Folder...");

        open.Add(solution);
        open.Add(folder);

        file.Display();
        Console.WriteLine();

        file.Remove(create);
        file.Display();
        Console.WriteLine();
        break;
    case 9:
        IProcessor transmitter = new Transmitter("12345");
        transmitter.Process();
        Console.WriteLine();

        Shell hammingCOder = new HammingCoder(transmitter);
        hammingCOder.Process();
        Console.WriteLine();

        Shell encoder = new Encryptor(transmitter);
        encoder.Process();
        Console.WriteLine();
        break;
    case 10:
        MarketPlace marketPlace = new MarketPlace();

        marketPlace.ProductReceipt();
        Console.WriteLine(new string('-', 20));
        marketPlace.ProviderReleasae();
        break;
    case 11:
        FlyweightFactory factoryFly = new FlyweightFactory(new List<Shared>()
        {
            new Shared("Microsoft", "manager"),
            new Shared("Google", "android-developer"),
            new Shared("Google", "web-developer")
        });
        factoryFly.List();
        AddSpecialistDatabase(factoryFly, "Google", "web-developer", "Mike", "AM-17234332");
        AddSpecialistDatabase(factoryFly, "Apple", "manager", "Aleks", "DE-22110332");
        factoryFly.List();
        break;
    case 12:
        ISite site = new SiteProxy(new GOF_Patterns.Proxy.Site());

        Console.WriteLine(site.GetPage(1));
        Console.WriteLine(site.GetPage(2));
        Console.WriteLine(site.GetPage(3));

        Console.WriteLine(site.GetPage(2));
        break;
    case 13:
        var designer = new GOF_Patterns.ChainOfResponsibility.Designer();
        var carpenter = new Carpenters();
        var finishingWorker = new FinishingWorker();

        designer.SetNextWorker(carpenter).SetNextWorker(finishingWorker);

        GetCommand(designer, "design a house");
        GetCommand(designer, "lay a brick");
        GetCommand(designer, "wallpapering");
        GetCommand(designer, "build a house");
        break;
    case 14:
        Conveyor conveyor = new Conveyor();

        Multipult multipult = new Multipult();
        multipult.SetCommand(0, new ConveyorCommand(conveyor));
        multipult.SetCommand(1, new ConveyorAdjustCommand(conveyor));
        multipult.PressOn(0);
        multipult.PressOn(1);
        multipult.PressCancel();
        multipult.PressCancel();
        break;
    case 15:
        DataStack stack1 = new DataStack();
        for (int i = 1; i < 5; i++)
            stack1.Push(i);

        DataStack stack2 = new DataStack(stack1);

        Console.WriteLine(stack1 == stack2);

        stack2.Push(10);

        Console.WriteLine(stack1 == stack2);
        break;
    case 16:
        GOF_Patterns.Mediator.Designer des = new GOF_Patterns.Mediator.Designer();
        GOF_Patterns.Mediator.Director dir = new GOF_Patterns.Mediator.Director();

        Controller mediator = new Controller(des, dir);

        dir.GiveCommand("Design");

        Console.WriteLine();

        des.ExecuteWork();
        break;
    case 17:
        Exchange exchange = new Exchange(10, 10);

        Memory memory = new Memory(exchange);

        exchange.GetDollars();
        exchange.GetEuro();

        Console.WriteLine("--- Dollar is sold, euro is bought ---");
        exchange.Sell();
        exchange.Buy();

        exchange.GetDollars();
        exchange.GetEuro();

        Console.WriteLine("--- State is saved ---");
        memory.BackUp();

        Console.WriteLine("--- Dollar is sold, euro is bought ---");
        exchange.Sell();
        exchange.Buy();

        exchange.GetDollars();
        exchange.GetEuro();

        Console.WriteLine("--- State is restored ---");
        memory.Undo();

        exchange.GetDollars();
        exchange.GetEuro();
        break;
    case 18:
        Product product = new Product(400);

        Wholesale wholesale = new Wholesale(product);
        Buyer buyer = new Buyer(product);

        product.ChangePrice(320);
        product.ChangePrice(280);
        break;
}

static void AddSpecialistDatabase(FlyweightFactory ff, string company, string position, string name, string passport)
{
    Console.WriteLine();
    Flyweight flyweight = ff.GetFlyweight(new Shared(company, position));
    flyweight.Process(new Unique(name, passport));
}

static void GetCommand(IWorker worker, string command)
{
    string str = worker.Execute(command);
    if (str == "")
        Console.WriteLine($"No one can do the {command}");
    else
        Console.WriteLine(str);
}