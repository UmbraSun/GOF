namespace GOF_Patterns.Abstract_Factory
{
    public class JapaniceCar : ICar
    {
        public void ReleaseCar(IEngine engine) => Console.WriteLine("Japanice car created");
    }
}
