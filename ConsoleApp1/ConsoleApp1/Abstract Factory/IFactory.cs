namespace GOF_Patterns.Abstract_Factory
{
    public interface IFactory
    {
        IEngine CreateEngine();
        ICar CreateCar();
    }
}
