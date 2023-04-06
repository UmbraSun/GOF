namespace GOF_Patterns.Mediator
{
    public class Director : Employee
    {
        private string text;
        public Director(IMediator mediator = null) : base( mediator) { }

        public void GiveCommand(string str)
        {
            text = str;
            if (text == "")
                Console.WriteLine("->Director know, what designer is working");
            else
                Console.WriteLine("->Director give command: " + text);

            _mediator.Notify(this, text);
        }
    }
}
