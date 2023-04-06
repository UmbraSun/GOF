namespace GOF_Patterns.Visitor
{
    public interface IPlace
    {
        void Accept(IVisitor v);
    }
}
