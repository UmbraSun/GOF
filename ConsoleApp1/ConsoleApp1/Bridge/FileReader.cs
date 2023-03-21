namespace GOF_Patterns.Bridge
{
    public class FileReader : IDataReader
    {
        public void Read() => Console.WriteLine("Data from file");
    }
}
