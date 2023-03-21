namespace GOF_Patterns.Factory_Method
{
    /// <summary>
    /// CarFactory product
    /// </summary>
    public class Car : IProduction
    {
        public Car()
        {
            Release();
        }

        public void Release() => Console.WriteLine("New car is releasing");
    }
}
