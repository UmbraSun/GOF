namespace GOF_Patterns.Flyweight
{
    public class Flyweight
    {
        private Shared _shared;

        public Flyweight(Shared shared) 
        {
            _shared = shared;
        }

        public void Process(Unique unique)
        {
            Console.WriteLine($"Displayed data: general {_shared.Company} _ {_shared.Position} and unique {unique.Name} _ {unique.Passport}");
        }

        public string GetData() => _shared.Company + " " + _shared.Position;
    }
}
