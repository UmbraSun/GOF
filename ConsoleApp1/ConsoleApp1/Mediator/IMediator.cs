namespace GOF_Patterns.Mediator
{
    public interface IMediator
    {
        void Notify(Employee emp, string msg);
    }
}
