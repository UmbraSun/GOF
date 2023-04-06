namespace GOF_Patterns.State
{
    public class GreenState : State
    {
        public override void NextState()
        {
            Console.WriteLine("From green to yellow");
            trafficLight.SetState(new YellowState());
        }

        public override void PreviosState()
        {
            Console.WriteLine("Green color");
        }
    }
}
