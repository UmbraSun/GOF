namespace GOF_Patterns.Adapter
{
    internal class OtherScales : IScales
    {
        private float _currentWeigth;

        public OtherScales(float currentWeigth) => _currentWeigth = currentWeigth;

        public float GetWeight() => _currentWeigth;
    }
}
