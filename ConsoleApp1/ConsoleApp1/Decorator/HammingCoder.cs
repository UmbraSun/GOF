namespace GOF_Patterns.Decorator
{
    public class HammingCoder : Shell
    {
        public HammingCoder(IProcessor processor) : base(processor)
        {
            
        }

        public override void Process()
        {
            Console.WriteLine("Hamming code is being superimposed->");
            _processor.Process();
        }
    }
}
