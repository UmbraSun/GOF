namespace GOF_Patterns.Composite
{
    public class DropDownItem : Item
    {
        private List<Item> children;

        public DropDownItem(string name) : base(name)
        {
            children = new List<Item>();
        }

        public override void Add(Item subItem)
        {
            children.Add(subItem);
        }

        public override void Remove(Item subItem)
        {
            children.Remove(subItem);
        }

        public override void Display()
        {
            foreach (var item in children)
            {
                if(ownerName != null)
                    Console.WriteLine(ownerName + " " + itemName);
                item.Display();
            }
        }
    }
}
