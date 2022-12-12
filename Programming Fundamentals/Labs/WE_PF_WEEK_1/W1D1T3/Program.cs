//Super Reduced String

using System;

namespace W1D1T3
{
    internal class Program
    {
        static void SuperReducedString(string s)
        {
            bool possible = true;
            while (possible)
            {
                possible = false;
                for (int i = 0; i < s.Length - 1; ++i)
                {
                    if (s[i] == s[i + 1])
                    {
                        s = s.Remove(i, 2);
                        possible = true;
                        break;
                    }
                }
            }
            Console.WriteLine(s.Length == 0 ? "Empty String" : s);
        }
        public static void Main()
        {
            string s = "aaabccddd";
            //Console.Write("{0} ", s[4]);
            SuperReducedString(s);
        }
    }
}
