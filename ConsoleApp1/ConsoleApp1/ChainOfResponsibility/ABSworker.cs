namespace GOF_Patterns.ChainOfResponsibility
{
    public abstract class ABSworker : IWorker
    {
        private IWorker nextWorker;
        public ABSworker() => nextWorker = null;

        public IWorker SetNextWorker(IWorker worker) 
        { 
            nextWorker = worker;
            return worker;
        }

        public virtual string Execute(string command)
        {
            if (nextWorker != null)
                return nextWorker.Execute(command);

            return string.Empty;
        }
    }
}
