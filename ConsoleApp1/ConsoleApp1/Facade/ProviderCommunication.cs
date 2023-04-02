namespace GOF_Patterns.Facade
{
    public class ProviderCommunication
    {
        public void Receive() => Console.WriteLine("Receipt of products from the manufacturer");

        public void Payment() => Console.WriteLine("Payment to the supplier with deduction of commission for the sale of products");
    }
}
