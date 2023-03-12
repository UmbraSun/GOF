namespace ConsoleApp1.Abstract_Factory
{
    public interface IFactory
    {
        IEngine CreateEngine();
        ICar CreateCar();
    }
}
