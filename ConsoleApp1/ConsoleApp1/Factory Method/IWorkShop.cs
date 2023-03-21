namespace GOF_Patterns.Factory_Method
{
    /// <summary>
    /// interface for our factory
    /// </summary>
    public interface IWorkShop
    {
        IProduction Create();
    }
}
