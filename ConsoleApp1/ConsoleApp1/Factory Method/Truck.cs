namespace ConsoleApp1.Factory_Method
{
    /// <summary>
    /// TruckFactory product
    /// </summary>
    public class Truck : IProduction
    {
        public Truck()
        {
            Release();   
        }

        public void Release() => Console.WriteLine("New track is releasing");
    }
}
