using System.Collections;

namespace GOF_Patterns.Flyweight
{
    public class FlyweightFactory
    {
        private Hashtable flywights;
        private string GetKey(Shared shared) => shared.Company + " " + shared.Position;

        public FlyweightFactory(List<Shared> shareds)
        {
            flywights = new Hashtable();
            foreach (var shared in shareds)
                flywights.Add(GetKey(shared), new Flyweight(shared));
        }

        public Flyweight GetFlyweight(Shared shared)
        {
            string key = GetKey(shared);
            if(!flywights.ContainsKey(key))
            {
                Console.WriteLine($"Flyweight factory: General object by key {key} not found. Creating new.");
                flywights.Add(key, new Flyweight(shared));
            }
            else
            {
                Console.WriteLine($"Flyweight factory: extract data from records by key {key}");
            }
            return (Flyweight)flywights[key];
        }

        public void List()
        {
            int count = flywights.Count;
            Console.WriteLine($"\nFlyweight factory: Count {count} of records");
            foreach(Flyweight flyweight in flywights)
            {
                Console.WriteLine(flyweight.GetData());
            }
        }
    }
}
