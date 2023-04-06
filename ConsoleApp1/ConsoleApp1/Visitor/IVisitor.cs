namespace GOF_Patterns.Visitor
{
    public interface IVisitor
    {
        void Visit(Zoo zoo);
        void Visit(Cinema cinema);
        void Visit(Circus circus);
    }
}
