//Write a program in C# to create a list of numbers and display the
// numbers greater than 20 in LINQ Query

using System;
using System.Collections.Generic;
using System.Linq;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int>();
            for (int i=0; i<=100; i=i+5)
                nums.Add(i);


            var res = nums.Where(num => num > 20);

            foreach (int i in res)
                Console.WriteLine(i);

        }
    }
}
