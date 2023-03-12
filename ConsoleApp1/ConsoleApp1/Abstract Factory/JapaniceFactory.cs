namespace ConsoleApp1.Abstract_Factory
{
    public class JapaniceFactory : IFactory
    {
        public ICar CreateCar() => new JapaniceCar();

        public IEngine CreateEngine() => new JapaniceEngine();
    }
}
