namespace ConsoleApp1.Abstract_Factory
{
    public class JapaniceEngine : IEngine
    {
        public JapaniceEngine()
        {
            ReleaseEngine();
        }

        public void ReleaseEngine() => Console.WriteLine("Japanice engine");
    }
}
