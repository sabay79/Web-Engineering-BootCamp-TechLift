//Simple Array Sum

using System;
using System.Collections.Generic;
using System.Linq;

namespace W1D2T3
{
    internal class Program
    {
        public static int SimpleArraySum(List<int> ar)
        {
            int sum = ar.Sum(x => x);
            return sum;
        }
        static void Main()
        {
            Console.WriteLine("Enter array elements:");
            List<int> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();

            Console.WriteLine("Sum of array elements: " + SimpleArraySum(ar));
        }
    }
}
