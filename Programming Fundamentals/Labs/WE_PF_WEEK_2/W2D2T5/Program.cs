//A very big sum

using System;
using System.Collections.Generic;
using System.Linq;

namespace W2D2T5
{
    internal class Program
    {
        public static long VeryBigSum(List<long> arr)
        {
            long sum = 0;
            for (int i = 0; i < arr.Count; i++)
                sum += arr[i];
            return sum;
        }
        static void Main()
        {
            Console.Write("Enter an Array: ");
            List<long> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt64(arTemp)).ToList();

            long result = VeryBigSum(arr);

            Console.WriteLine("Sum of Array Elements: " + result);

        }
    }
}
