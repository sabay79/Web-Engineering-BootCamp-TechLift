//Reverse Array

using System;
using System.Collections.Generic;
using System.Linq;

namespace W2D1T1
{
    internal class Program
    {
        public static List<int> ReverseArray(List<int> a)
        {
            List<int> rArr = new List<int>();
            for (int i = (a.Count) - 1; i >= 0; i--)
                rArr.Add(a[i]);

            return rArr;
        }
        static void Main()
        {
            Console.WriteLine("Enter an Array");
            //List<int> arr = new List<int>() { 1, 2, 3, 4 };
            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            Console.WriteLine("\nReverse Array");
            List<int> res = ReverseArray(arr);
            Console.WriteLine(String.Join(" ", res));
        }
    }
}
