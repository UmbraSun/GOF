namespace GOF_Patterns.Visitor
{
    public class Zoo : IPlace
    {
        public void Accept(IVisitor v) => v.Visit(this);
    }
}
