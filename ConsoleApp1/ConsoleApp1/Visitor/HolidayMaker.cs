namespace GOF_Patterns.Visitor
{
    public class HolidayMaker : IVisitor
    {
        public string value;

        public void Visit(Zoo zoo) => value = "Elephant in the zoo";

        public void Visit(Cinema cinema) => value = "Film - Garry Poter";

        public void Visit(Circus circus) => value = "Сlown in the circus";
    }
}
