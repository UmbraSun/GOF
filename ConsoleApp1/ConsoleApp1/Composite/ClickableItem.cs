namespace GOF_Patterns.Composite
{
    public class ClickableItem : Item
    {
        public ClickableItem(string name) : base(name)
        {
        }

        public override void Add(Item subItem)
        {
            throw new Exception();
        }

        public override void Remove(Item subItem)
        {
            throw new Exception();
        }

        public override void Display()
        {
            Console.WriteLine(itemName);
        }
    }
}
