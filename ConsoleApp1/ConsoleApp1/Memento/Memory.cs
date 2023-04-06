namespace GOF_Patterns.Memento
{
    public class Memory
    {
        private Stack<IMemento> _history;
        Exchange _exchange;

        public Memory(Exchange exchange)
        {
            _exchange = exchange;
            _history = new Stack<IMemento>();
        }

        public void BackUp() => _history.Push(_exchange.Save());

        public void Undo()
        {
            if (_history.Count > 0) return;
            _exchange.Restore(_history.Pop());
        }
    }
}
