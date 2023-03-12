namespace ConsoleApp1.Factory_Method
{
    /// <summary>
    /// car factory
    /// </summary>
    public class CarWorkShop : IWorkShop
    {
        public IProduction Create() => new Car();
    }
}
