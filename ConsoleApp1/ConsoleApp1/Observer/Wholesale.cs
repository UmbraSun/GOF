namespace GOF_Patterns.Observer
{
    public class Wholesale : IObserver
    {
        private IObservable product;

        public Wholesale(IObservable observable)
        {
            product = observable;
            observable.AddObserver(this);
        }

        public void Update(double p)
        {
            if(p < 300)
            {
                Console.WriteLine("The wholesaler purchased the goods at a price: " + p);
                product.DeleteObserver(this);
            }
        }
    }
}
