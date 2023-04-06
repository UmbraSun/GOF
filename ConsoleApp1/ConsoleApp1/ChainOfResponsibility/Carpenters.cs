namespace GOF_Patterns.ChainOfResponsibility
{
    public class Carpenters : ABSworker
    {
        public override string Execute(string command)
        {
            if (command == "lay a brick")
                return $"Command is executed by carpenters. Command: {command}";
            else
                return base.Execute(command);
        }
    }
}
