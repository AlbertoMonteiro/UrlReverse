using System.Linq;

namespace UrlReverse
{
    public static class StringExtensions
    {
        public static string Inverter(this string me)
        {
            return me.Aggregate("", (acc, c) => c + acc);
        }
    }
}
