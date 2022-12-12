//Diagonal Difference
//Given a square matrix, calculate the absolute difference between the sums of its diagonals.

using System;
using System.Collections.Generic;
using System.Linq;

namespace W1D2T4
{
    internal class Program
    {
        public static int DiagonalDifference(int n, List<List<int>> arr)
        {
            var matrix = arr.ToArray();

            int diag1 = 0;
            int diag2 = 0;

            for (int i = 0, j = n - 1; i < n; i++, j--)
            {
                diag1 += matrix[i][i];
                diag2 += matrix[i][j];
            }
            Console.WriteLine("\nSum across Primary Diagonal: " + diag1);
            Console.WriteLine("Sum across Secondary Diagonal: " + diag2);

            int diagonalDifference = Math.Abs(diag1 - diag2);
            return diagonalDifference;
        }
        static void Main()
        {
            Console.WriteLine("Enter size of Square Matrix: ");
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            Console.WriteLine("\nEnter Elements for " + n + "x" + n + " matrix:");
            List<List<int>> arr = new List<List<int>>();

            for (int i = 0; i < n; i++)
            {
                arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            }
            Console.WriteLine("\nDiagonal Difference: " + DiagonalDifference(n, arr) + "\n");
        }
    }
}
