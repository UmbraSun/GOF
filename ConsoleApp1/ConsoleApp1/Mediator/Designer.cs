namespace GOF_Patterns.Mediator
{
    public class Designer : Employee
    {
        private bool IsWorking;
        public Designer(IMediator mediator = null) : base(mediator)
        { }
        
        public void ExecuteWork()
        {
            Console.WriteLine("<-Designer is working");
            _mediator.Notify(this, "Designer is designing");
        }

        public void SetWork(bool state)
        {
            IsWorking = state;
            if (state)
                Console.WriteLine("<-Designer he is out of work now");
            else
                Console.WriteLine("<-Designer is busy");
        }
    }
}
