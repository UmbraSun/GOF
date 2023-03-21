namespace GOF_Patterns.Builder
{
    public class Director
    {
        private IDeveloper _developer;

        public Director(IDeveloper developer) => _developer = developer;

        public void SetDeveloper(IDeveloper developer) => _developer = developer;

        public Phone MountOnlyPhone() 
        {
            _developer.CreateBox();
            _developer.CraeteDisplay();
            return _developer.GetPhone();
        }

        public Phone MountFullPhone()
        {
            _developer.CreateBox();
            _developer.CraeteDisplay();
            _developer.SystemInstall();
            return _developer.GetPhone();
        }
    }
}
