namespace GOF_Patterns.Bridge
{
    public class TelegramBotSender : Sender
    {
        public TelegramBotSender(IDataReader reader) : base(reader)
        {
            
        }

        public override void Send()
        {
            reader.Read();
            Console.WriteLine("send with Telegram bot");
        }
    }
}
