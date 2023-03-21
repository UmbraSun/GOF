namespace GOF_Patterns.Prototype
{
    public interface IAnimal
    {
        void SetName(string name);
        string GetName();
        IAnimal Clone();
    }
}
