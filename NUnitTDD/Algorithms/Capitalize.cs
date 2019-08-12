using System;
using System.Linq;

namespace NUnitTDD.Algorithms
{
    public class Capitalize
    {
        public static string CapitalizeWords(string str)
        {
            if (str == null) throw new ArgumentNullException();
            
            var words = str.Split(' ');
            var capitalizedString = "";

            foreach (var word in words)
            {
                capitalizedString += (word.First().ToString().ToUpper() + word.Substring(1) + " ");
            }

            return capitalizedString.Trim();
        }
    }
}