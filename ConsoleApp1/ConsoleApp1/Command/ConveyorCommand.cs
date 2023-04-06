namespace GOF_Patterns.Command
{
    public class ConveyorCommand : ICommand
    {
        private Conveyor _conveyor;

        public ConveyorCommand(Conveyor conveyor)
        {
            _conveyor = conveyor;
        }

        public void Negative() => _conveyor.Off();

        public void Positive() => _conveyor.On();
    }
}
