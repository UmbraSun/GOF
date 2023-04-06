namespace GOF_Patterns.ChainOfResponsibility
{
    public interface IWorker
    {
        IWorker SetNextWorker(IWorker worker);
        string Execute(string command);
    }
}
