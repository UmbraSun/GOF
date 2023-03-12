namespace ConsoleApp1.Factory_Method
{
    /// <summary>
    /// interface for our factory
    /// </summary>
    public interface IWorkShop
    {
        IProduction Create();
    }
}
