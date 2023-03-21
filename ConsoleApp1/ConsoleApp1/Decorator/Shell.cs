namespace GOF_Patterns.Decorator
{
    public class Shell : IProcessor
    {
        protected IProcessor _processor;

        public Shell(IProcessor processor)
        {
            _processor = processor;
        }

        public virtual void Process() => _processor.Process();
    }
}
