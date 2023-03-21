using System.Text;

namespace GOF_Patterns.Builder
{
    public class Phone
    {
        StringBuilder data;
        public Phone() => data = new StringBuilder("");
        public string AboutPhone() => data.ToString();
        public void AppendData(string str) => data.Append(str);
    }
}
