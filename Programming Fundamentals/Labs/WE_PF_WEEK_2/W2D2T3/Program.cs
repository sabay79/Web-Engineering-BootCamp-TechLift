//Simple Array Sum

using System;
using System.Collections.Generic;
using System.Linq;

namespace W2D2T3
{
    internal class Program
    {
        public static int SimpleArraySum(List<int> arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Count; i++)
                sum += arr[i];
            return sum;
        }
        static void Main()
        {
            Console.Write("Enter an Array: ");
            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();

            int result = SimpleArraySum(arr);

            Console.WriteLine("Sum of Array Elements: " + result);
        }
    }
}
