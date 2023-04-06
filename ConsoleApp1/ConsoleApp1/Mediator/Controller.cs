namespace GOF_Patterns.Mediator
{
    public class Controller : IMediator
    {
        private Designer _designer;
        private Director _director;

        public Controller(Designer designer, Director director)
        {
            _designer = designer;
            _director = director;
            designer.SetMediator(this);
            director.SetMediator(this);
        }

        public void Notify(Employee emp, string msg)
        {
            if(emp is Director dir)
                if (msg == "")
                    _designer.SetWork(false);
                else
                    _designer.SetWork(true);
            if (emp is Designer des)
                if (msg == "Designer is working")
                    _director.GiveCommand("");

        }
    }
}
