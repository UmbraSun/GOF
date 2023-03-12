namespace ConsoleApp1.Prototype
{
    public interface IAnimal
    {
        void SetName(string name);
        string GetName();
        IAnimal Clone();
    }
}
