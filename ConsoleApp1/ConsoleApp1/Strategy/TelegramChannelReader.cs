namespace GOF_Patterns.Strategy
{
    internal class TelegramChannelReader : IReader
    {
        public void Parse(string url) => Console.WriteLine("Parse from Telegram channel: " + url);
    }
}
