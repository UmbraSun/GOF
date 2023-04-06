namespace GOF_Patterns.Template_method
{
    public class DigirTransmitter : Transmitter
    {
        protected override void Simpling() => Console.WriteLine("discretization of the recorded fragment");
        protected override void Digitization() => Console.WriteLine("digitization");
        protected override void Modulation() => Console.WriteLine("Modulation digital signal");
    }
}
