namespace GOF_Patterns.Bridge
{
    public class DatabaseReader : IDataReader
    {
        public void Read() => Console.WriteLine("Data from DB");
    }
}
