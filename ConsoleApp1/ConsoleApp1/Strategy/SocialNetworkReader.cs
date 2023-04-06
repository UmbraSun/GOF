namespace GOF_Patterns.Strategy
{
    public class SocialNetworkReader : IReader
    {
        public void Parse(string url) => Console.WriteLine("Parse from social network news feed: " + url);
    }
}
