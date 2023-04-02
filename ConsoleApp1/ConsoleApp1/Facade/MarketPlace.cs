namespace GOF_Patterns.Facade
{
    public class MarketPlace
    {
        private ProviderCommunication _providerCommunication;
        private Site _site;
        private Database _database;

        public MarketPlace()
        {
            _providerCommunication = new ProviderCommunication();
            _site = new Site();
            _database = new Database();
        }

        public void ProductReceipt()
        {
            _providerCommunication.Receive();
            _site.Placement();
            _database.Insert();
        }

        public void ProviderReleasae()
        {
            _providerCommunication.Payment();
            _site.Delete();
            _database.Delete();
        }
    }
}
