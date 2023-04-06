namespace GOF_Patterns.Observer
{
    public interface IObservable
    {
        void AddObserver(IObserver ob);
        void DeleteObserver(IObserver ob);
        void Notify();
    }
}
