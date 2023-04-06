namespace GOF_Patterns.Mediator
{
    public abstract class Employee
    {
        protected IMediator _mediator;
        public Employee(IMediator mediator) =>  _mediator = mediator;

        public void SetMediator(IMediator mediator) => _mediator = mediator;
    }
}
