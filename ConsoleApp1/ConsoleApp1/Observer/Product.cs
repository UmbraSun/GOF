namespace GOF_Patterns.Observer
{
    public class Product : IObservable
    {
        private List<IObserver> _observers;
        private double _price;

        public Product(double price)
        {
            _observers = new List<IObserver>();
            _price = price;
        }

        public void ChangePrice(double pr)
        {
            _price = pr;
            Notify();
        }

        public void AddObserver(IObserver ob)
        {
            _observers.Add(ob);
        }

        public void DeleteObserver(IObserver ob)
        {
            _observers.Remove(ob);
        }

        public void Notify()
        {
            foreach (var ob in _observers.ToList())
                ob.Update(_price);
        }
    }
}
