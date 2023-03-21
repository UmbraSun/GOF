﻿namespace GOF_Patterns.Adapter
{
    public class AmericanScales : IScales
    {
        private float _currentWeigth;
        public AmericanScales(float currentWeigth) => _currentWeigth = currentWeigth;

        public float GetWeight() => _currentWeigth;
    }
}
