namespace GOF_Patterns.Observer
{
    public class Buyer : IObserver
    {
        private IObservable product;

        public Buyer(IObservable observable)
        {
            product = observable;
            observable.AddObserver(this);
        }

        public void Update(double p)
        {
            if (p < 350)
            {
                Console.WriteLine("The buyer purchased the goods at a price: " + p);
                product.DeleteObserver(this);
            }
        }
    }
}
