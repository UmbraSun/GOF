namespace GOF_Patterns.Command
{
    public class ConveyorAdjustCommand : ICommand
    {
        private Conveyor _conveyor;

        public ConveyorAdjustCommand(Conveyor conveyor)
        {
            _conveyor = conveyor;
        }

        public void Negative() => _conveyor.SpeedDecreased();

        public void Positive() => _conveyor.SpeedIncreased();
    }
}
