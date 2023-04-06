namespace GOF_Patterns.Strategy
{
    public class NewsSiteReader : IReader
    {
        public void Parse(string url) => Console.WriteLine("Parse from site: " + url);
    }
}
