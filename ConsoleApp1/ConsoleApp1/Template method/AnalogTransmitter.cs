namespace GOF_Patterns.Template_method
{
    public class AnalogTransmitter : Transmitter
    {
        protected override void Modulation() => Console.WriteLine("Modulation analog signal");
    }
}
