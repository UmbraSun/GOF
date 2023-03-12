namespace ConsoleApp1.Abstract_Factory
{
    public class JapaniceCar : ICar
    {
        public void ReleaseCar(IEngine engine) => Console.WriteLine("Japanice car created");
    }
}
