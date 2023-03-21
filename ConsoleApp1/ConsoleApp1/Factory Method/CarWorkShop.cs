namespace GOF_Patterns.Factory_Method
{
    /// <summary>
    /// car factory
    /// </summary>
    public class CarWorkShop : IWorkShop
    {
        public IProduction Create() => new Car();
    }
}
