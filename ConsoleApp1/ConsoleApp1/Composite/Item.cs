namespace GOF_Patterns.Composite
{
    public abstract class Item
    {
        protected string itemName;
        protected string ownerName;
        public void SetOwned(string name) => ownerName = name;
        public Item(string name) => itemName = name;
        public virtual void Add(Item subItem) { }
        public virtual void Remove(Item subItem) { }
        public abstract void Display();
    }
}
