namespace GOF_Patterns.Abstract_Factory
{
    public class AmericanFactory : IFactory
    {
        public ICar CreateCar() => new AmericanCar();

        public IEngine CreateEngine() => new AmericanEngine();
    }
}
