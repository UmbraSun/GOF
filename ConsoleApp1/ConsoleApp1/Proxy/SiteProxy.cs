namespace GOF_Patterns.Proxy
{
    public class SiteProxy : ISite
    {
        private ISite _site;
        private Dictionary<int, string> cache;

        public SiteProxy(ISite site)
        {
            _site = site;
            cache = new Dictionary<int, string>();
        }

        public string GetPage(int num)
        {
            string page;
            if (cache.ContainsKey(num))
            {
                page = "from cache " + cache[num];
            }
            else
            {
                page = _site.GetPage(num);
                cache.Add(num, page);
            }
            return page;
        }
    }
}
