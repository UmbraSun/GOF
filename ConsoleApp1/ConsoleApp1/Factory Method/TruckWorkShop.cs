namespace GOF_Patterns.Factory_Method
{
    /// <summary>
    /// Truck factory
    /// </summary>
    public class TruckWorkShop : IWorkShop
    {
        public IProduction Create() => new Truck();
    }
}
