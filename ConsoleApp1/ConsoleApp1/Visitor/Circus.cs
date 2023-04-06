namespace GOF_Patterns.Visitor
{
    public class Circus : IPlace
    {
        public void Accept(IVisitor v) => v.Visit(this);
    }
}
