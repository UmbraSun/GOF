namespace ConsoleApp1.Adapter
{
    public class AdapterForAmericanScales : IScales
    {
        AmericanScales _scales;

        public AdapterForAmericanScales(AmericanScales scales) => _scales = scales;

        public float GetWeight() => _scales.GetWeight() * 0.453f;
    }
}
