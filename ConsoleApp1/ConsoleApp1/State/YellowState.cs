namespace GOF_Patterns.State
{
    public class YellowState : State
    {
        public override void NextState()
        {
            Console.WriteLine("From yellow to red");
            trafficLight.SetState(new RedState());
        }

        public override void PreviosState()
        {
            Console.WriteLine("From yellow to green");
            trafficLight.SetState(new GreenState());
        }
    }
}
