namespace GOF_Patterns.Bridge
{
    public class EmailSender :  Sender
    {
        public EmailSender(IDataReader reader) : base(reader)
        {
        }

        public override void Send()
        {
            reader.Read();
            Console.WriteLine("send with Email");
        }
    }
}
