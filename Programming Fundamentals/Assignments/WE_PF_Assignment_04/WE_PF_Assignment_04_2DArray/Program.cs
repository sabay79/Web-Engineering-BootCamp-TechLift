//2D Array - 6x6 Hourglass sum

using System;
using System.Collections.Generic;
using System.Linq;

namespace WE_PF_Assignment_04_2DArray
{
    internal class Program
    {
        public static int HourglassSum(List<List<int>> arr)
        {
            List<int> sums = new List<int>();

            for (int i = 1; i < 5; i++)
                for (int j = 1; j < 5; j++)
                {
                    int sum = arr[i - 1][j - 1] + arr[i - 1][j] + arr[i - 1][j + 1]
                                                + arr[i][j]
                            + arr[i + 1][j - 1] + arr[i + 1][j] + arr[i + 1][j + 1];
                    sums.Add(sum);
                }
            return sums.Max();
        }
        static void Main()
        {
            Console.WriteLine("Enter 6x6 Matrix:");
            List<List<int>> arr = new List<List<int>>();

            for (int i = 0; i < 6; i++)
            {
                arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            }

            int result = HourglassSum(arr);

            Console.WriteLine("The maximum hourglass sum is " + result);
        }
    }
}

