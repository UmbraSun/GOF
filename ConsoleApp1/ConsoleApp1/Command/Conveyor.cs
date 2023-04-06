namespace GOF_Patterns.Command
{
    public class Conveyor
    {
        public void On() => Console.WriteLine("Conveyor turn on");
        public void Off() => Console.WriteLine("Conveyor turn off");
        public void SpeedIncreased() => Console.WriteLine("Conveyor speed increased");
        public void SpeedDecreased() => Console.WriteLine("Conveyor speed decreased");
    }
}
