namespace GOF_Patterns.ChainOfResponsibility
{
    public class Designer : ABSworker
    {
        public override string Execute(string command)
        {
            if (command == "design a house")
                return $"Command is executed by designer. Command: {command}";
            else
                return base.Execute(command);
        }
    }
}
