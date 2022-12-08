//Left Rotation

using System;
using System.Collections.Generic;
using System.Linq;

namespace W2D1T4
{
    internal class Program
    {
        public static List<int> RotateLeft(int d, List<int> arr)
        {
            int temp = 0;
            for (int i = 0; i < d; i++)
            {
                temp = arr[0];
                arr.RemoveAt(0);
                arr.Add(temp);
            }
            return arr;
        }
        static void Main()
        {
            Console.Write("Enter Amount to Rotate by: ");
            int d = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Array to Rotate: ");
            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            List<int> result = RotateLeft(d, arr);

            Console.WriteLine(String.Join(" ", result));
        }
    }
}
