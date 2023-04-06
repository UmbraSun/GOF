namespace GOF_Patterns.State
{
    public class RedState : State
    {
        public override void NextState()
        {
            Console.WriteLine("Red color");
            trafficLight.SetState(new RedState());
        }

        public override void PreviosState()
        {
            Console.WriteLine("From red to yellow");
            trafficLight.SetState(new YellowState());
        }
    }
}
