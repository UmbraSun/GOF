namespace GOF_Patterns.Bridge
{
    public abstract class Sender
    {
        protected IDataReader reader;
        public Sender(IDataReader reader) => 
            this.reader = reader;

        public void SetDataReader(IDataReader rd) => reader = rd;

        public abstract void Send();
    }
}
