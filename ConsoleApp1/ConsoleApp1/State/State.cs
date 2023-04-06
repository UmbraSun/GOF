namespace GOF_Patterns.State
{
    public abstract class State
    {
        protected TrafficLight trafficLight;
        public TrafficLight TrafficLight { set => trafficLight = value; }

        public abstract void NextState();
        public abstract void PreviosState();
    }
}
