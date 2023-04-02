namespace GOF_Patterns.Flyweight
{
    public class Shared
    {
        private string _company;
        private string _position;

        public Shared(string company, string position)
        {
            _company = company;
            _position = position;
        }

        public string Company { get => _company; }

        public string Position { get => _position; }
    }
}
