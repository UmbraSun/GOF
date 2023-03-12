namespace ConsoleApp1.Abstract_Factory
{
    public class AmericanEngine : IEngine
    {
        public AmericanEngine()
        {
            ReleaseEngine();
        }

        public void ReleaseEngine() => Console.WriteLine("American engine");
    }
}
