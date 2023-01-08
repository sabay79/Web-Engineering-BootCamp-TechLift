//Write a program in C# to display the name of the days of a week in LINQ Query

using System;
using System.Linq;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var week = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            var res= from day in week
                     select day;

            Console.WriteLine("Days in a week: \n");
            foreach (var d in res)
            {
                Console.WriteLine(d);
            }
            Console.ReadLine();
        }
    }
}
