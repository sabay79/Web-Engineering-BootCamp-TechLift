//Compare the triplets

using System;
using System.Collections.Generic;
using System.Linq;

namespace W2D2T4
{
    internal class Program
    {
        public static List<int> CompareTriplets(List<int> a, List<int> b)
        {
            int scoreAlice = 0, scoreBob = 0;
            for (int i = 0; i < a.Count; i++)
            {
                if (a[i] > b[i])
                    scoreAlice++;
                else if (a[i] < b[i])
                    scoreBob++;
                else
                    break;
            }
            List<int> r = new List<int>() { scoreAlice, scoreBob };
            return r;
        }
        static void Main()
        {
            Console.Write("Enter Alice's Challenge Rating: ");
            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            Console.Write("Enter Bob's Challenge Rating: ");
            List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

            List<int> result = CompareTriplets(a, b);

            Console.WriteLine("Alice vs Bob Score: " + String.Join(" ", result));
        }
    }
}
