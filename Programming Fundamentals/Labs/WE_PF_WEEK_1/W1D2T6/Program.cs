//Staircase
//Its base and height are both equal to .
//It is drawn using # symbols and spaces. The last line is not preceded by any spaces.

using System;

namespace W1D2T6
{
    internal class Program
    {
        public static void StairCase(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - 1 - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k <= i; k++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
        }
        static void Main()
        {
            Console.WriteLine("Enter size of staircase:");
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            StairCase(n);
        }
    }
}
