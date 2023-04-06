namespace GOF_Patterns.Strategy
{
    public class ResourceReader
    {
        private IReader _reader;
        public ResourceReader(IReader reader) => _reader = reader;

        public void SetStrategy(IReader reader) => _reader = reader;

        public void Read(string url) => _reader.Parse(url);
    }
}
