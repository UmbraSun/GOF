namespace GOF_Patterns.Memento
{
    public class Exchange
    {
        private int _dollars;
        private int _euro;

        public Exchange(int dollars, int euro)
        {
            _dollars = dollars;
            _euro = euro;
        }

        public void GetDollars() => Console.WriteLine("Dollars: " + _dollars);
        public void GetEuro() => Console.WriteLine("Euro: " + _euro);
        public void Sell() 
        {
            if (_dollars > 0) --_dollars;
        }

        public void Buy() => ++_euro;

        public ExchangeMemento Save() => new ExchangeMemento(_dollars, _euro);
        public void Restore(IMemento memento)
        {
            _dollars = memento.GetDollars();
            _euro = memento.GetEuro();
        }
    }
}
