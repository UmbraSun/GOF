namespace GOF_Patterns.Proxy
{
    public class Site : ISite
    {
        public string GetPage(int num) => "This page is " + num;
    }
}
