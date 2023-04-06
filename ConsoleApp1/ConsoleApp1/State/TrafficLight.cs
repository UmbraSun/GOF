namespace GOF_Patterns.State
{
    public class TrafficLight
    {
        private State _state;

        public TrafficLight(State state)
        {
            _state = state;
        }

        public void SetState(State state) 
        {
            _state = state;
            state.TrafficLight = this;
        }

        public void NextState()
        {
            _state.NextState();
        }

        public void PreviousState()
        {
            _state.PreviosState();
        }
    }
}
