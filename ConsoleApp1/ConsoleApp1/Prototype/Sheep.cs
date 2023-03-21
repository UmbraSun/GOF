namespace GOF_Patterns.Prototype
{
    public class Sheep : IAnimal
    {
        private string _name;

        public Sheep() { }
        public Sheep(Sheep donor) => _name = donor._name;

        public IAnimal Clone() => new Sheep(this);

        public string GetName() => _name;

        public void SetName(string name) => _name = name;
    }
}
