namespace GOF_Patterns.Template_method
{
    public abstract class Transmitter
    {
        protected virtual void VoiceRecord() => Console.WriteLine("Record of voice");
        protected virtual void Simpling() { }
        protected virtual void Digitization() { }
        protected virtual void Modulation() { }
        protected virtual void Transmission() => Console.WriteLine("Transmission by radio");

        public void ProcessStart()
        {
            VoiceRecord();
            Simpling();
            Digitization();
            Modulation();
            Transmission();
        }
    }
}
