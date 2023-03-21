namespace GOF_Patterns.Decorator
{
    public class Transmitter : IProcessor
    {
        private string _data;
        public Transmitter(string data) => _data = data;
        public void Process() => Console.WriteLine("Data " + _data + " translated for Transmitter");
    }
}
