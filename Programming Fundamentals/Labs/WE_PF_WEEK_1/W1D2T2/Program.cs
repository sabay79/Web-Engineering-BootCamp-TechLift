//HackerRank in a String
//A string contains the word hackerrank if a subsequence of its characters spell the word hackerrank.
//Remeber that a subsequence maintains the order of characters selected from a sequence.

using System;
using System.Text.RegularExpressions;

namespace W1D2T2
{
    internal class Program
    {
        public static bool HackerRankInString(string s)
        {
            var reg = string.Join(".*?", "hackerrank".ToCharArray());
            bool answer = Regex.IsMatch(s, reg);
            return answer;
        }
        static void Main()
        {
            Console.WriteLine("Check if the string contains the word \"hackerrank\" or not.\n" +
                "Enter the number of strings you want to check: ");

            int q = Convert.ToInt32(Console.ReadLine().Trim());

            for (int qItr = 1; qItr <= q; qItr++)
            {
                Console.WriteLine("\n({0}) Enter a Word:", qItr);
                string s = Console.ReadLine();

                string result = (HackerRankInString(s) == true ? "YES" : "NO");
                Console.WriteLine(result);
            }
        }
    }
}
