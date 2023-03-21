namespace GOF_Patterns.Decorator
{
    public class Encryptor : Shell
    {
        public Encryptor(IProcessor processor) : base(processor)
        {
            
        }

        public override void Process()
        {
            Console.WriteLine("Data encryption->");
            _processor.Process();
        }
    }
}
