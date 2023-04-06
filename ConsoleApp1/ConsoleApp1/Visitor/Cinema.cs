namespace GOF_Patterns.Visitor
{
    public class Cinema : IPlace
    {
        public void Accept(IVisitor v) => v.Visit(this);
    }
}
