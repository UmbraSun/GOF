namespace ConsoleApp1.Abstract_Factory
{
    public class AmericanCar : ICar
    {
        public void ReleaseCar(IEngine engine) => Console.WriteLine("American car created");

    }
}
