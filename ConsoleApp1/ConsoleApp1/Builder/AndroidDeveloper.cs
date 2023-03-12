namespace ConsoleApp1.Builder
{
    public class AndroidDeveloper : IDeveloper
    {
        private Phone _phone;

        public AndroidDeveloper() => _phone = new Phone();

        public void CraeteDisplay() => _phone.AppendData("Android display created ");

        public void CreateBox() => _phone.AppendData("Android box created ");
        
        public void SystemInstall() => _phone.AppendData("Android system installed ");

        public Phone GetPhone() => _phone;
    }
}
