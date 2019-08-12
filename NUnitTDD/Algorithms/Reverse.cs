using System;

namespace NUnitTDD.Algorithms
{
    public class Reverse
    {
        public static string StringReversal(string str)
        {
            string reversed = "";

            for (var i = 0; i < str.Length; i++)
            {
                reversed += str[str.Length - i - 1];
            }

            return reversed;
        }

        public static int IntReversal(int n)
        {
            return Math.Sign(n) * Convert.ToInt32(StringReversal(Math.Abs(n).ToString()));
        }
    }
}