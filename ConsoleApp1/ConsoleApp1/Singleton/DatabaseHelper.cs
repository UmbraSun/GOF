using System.Text;

namespace ConsoleApp1.Singleton
{
    public class DatabaseHelper
    {
        private StringBuilder data = new StringBuilder();
        private static DatabaseHelper databaseConnection;

        private DatabaseHelper() => Console.WriteLine("DB connection");

        public static DatabaseHelper GetConnection()
        {
            if(databaseConnection == null)
                databaseConnection = new DatabaseHelper();
            return databaseConnection;
        }

        public string SelectData() => data.ToString();
        public void InsertData(string d)
        {
            Console.WriteLine("New data " + d);
            data.Append(d);
        }
    }
}
