namespace GOF_Patterns.Builder
{
    public class IphoneDeveloper : IDeveloper
    {
        private Phone _phone;

        public IphoneDeveloper() => _phone = new Phone();

        public void CraeteDisplay() => _phone.AppendData("Iphone display created ");

        public void CreateBox() => _phone.AppendData("Iphone box created ");

        public void SystemInstall() => _phone.AppendData("IOS install ");

        public Phone GetPhone() => _phone;
    }
}
