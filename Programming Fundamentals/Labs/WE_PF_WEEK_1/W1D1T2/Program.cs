//Camel Case

using System;

namespace W1D1T2
{
    internal class Program
    {
        public static int CamelCase(string s)
        {
            int count = 1;

            for (int i = 1; i < s.Length - 1; i++)
            {

                if (char.IsUpper(s[i]))
                    count++;
            }

            return count;

        }
        static void Main()
        {
            string cs = "myNameIsSaba";
            Console.Write("\"" + cs + "\" has " + CamelCase(cs) + " words.\n");
        }
    }
}
