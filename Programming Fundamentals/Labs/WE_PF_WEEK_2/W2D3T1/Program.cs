//Selection Sort

using System;

namespace W2D3T1
{
    internal class Program
    {
        static void SortArray(ref int[] arr)
        {
            int n = arr.Length;

            // One by one move boundary of unsorted subarray
            for (int i = 0; i < n - 1; i++)
            {
                // Find the minimum element in unsorted array
                int min_idx = i;
                for (int j = i + 1; j < n; j++)
                    if (arr[j] < arr[min_idx])
                        min_idx = j;

                // Swap the found minimum element with the first element
                int temp = arr[min_idx];
                arr[min_idx] = arr[i];
                arr[i] = temp;
            }
        }
        static void PrintArray(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }
        static void Main()
        {
            int[] arr = { 5, 25, 10, 20, 15 };
            Console.Write("Unsorted Array: ");
            PrintArray(arr);

            SortArray(ref arr);
            Console.Write("Sorted Array: ");
            PrintArray(arr);
        }
    }
}