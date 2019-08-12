using System.Linq;

namespace NUnitTDD.Algorithms
{
    public class Vowels
    {
        public static int GetCount(string str)
        {
            return str.Count("aeiouAEIOU".Contains);
        }
    }
}