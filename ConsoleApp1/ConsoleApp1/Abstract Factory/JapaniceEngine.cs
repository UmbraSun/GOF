namespace GOF_Patterns.Abstract_Factory
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
