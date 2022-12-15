//Plus Minus
//Given an array of integers, calculate the ratios of its elements that are positive, negative, and zero.
//Print the ratios of positive, negative and zero values in the array.
//Each value should be printed on a separate line with  digits after the decimal.
//The function should not return a value.

using System;
using System.Collections.Generic;
using System.Linq;

namespace W1D2T5
{
    internal class Program
    {
        public static void PlusMinus(int n, List<int> arr)
        {
            int positiveCount = 0;
            int negativeCount = 0;
            int zeroCount = 0;

            for (int i = 0; i < n; i++)
            {
                if (arr[i] == 0) zeroCount++;
                else if (arr[i] > 0) positiveCount++;
                else negativeCount++;
            }
            Console.WriteLine("\nPositive Ratio: " + string.Format("{0:0.000000}", positiveCount / (decimal)n));
            Console.WriteLine("Negative Ratio: " + string.Format("{0:0.000000}", negativeCount / (decimal)n));
            Console.WriteLine("Zeros Ratio: " + string.Format("{0:0.000000}", zeroCount / (decimal)n));
        }
        static void Main()
        {
            Console.WriteLine("Enter the size of array:");
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            Console.WriteLine("\nEnter array of Integers:");
            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            PlusMinus(n, arr);
        }
    }
}
