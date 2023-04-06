namespace GOF_Patterns.Memento
{
    public class ExchangeMemento : IMemento
    {
        private int _dollars;
        private int _euro;

        public ExchangeMemento(int dollars, int euro)
        {
            _dollars = dollars;
            _euro = euro;
        }

        public int GetDollars() => _dollars;
        public int GetEuro() => _euro;
    }
}
