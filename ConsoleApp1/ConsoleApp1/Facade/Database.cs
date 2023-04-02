namespace GOF_Patterns.Facade
{
    public class Database
    {
        public void Insert() => Console.WriteLine("Add record to database");

        public void Delete() => Console.WriteLine("Delete record from database");
    }
}
