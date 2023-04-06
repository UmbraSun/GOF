namespace GOF_Patterns.ChainOfResponsibility
{
    public class FinishingWorker : ABSworker
    {
        public override string Execute(string command)
        {
            if (command == "wallpapering")
                return $"Command is executed by finishing worker. Command: {command}";
            else
                return base.Execute(command);
        }
    }
}
