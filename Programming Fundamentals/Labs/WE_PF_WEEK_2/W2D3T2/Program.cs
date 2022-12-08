//Bubble Sort

using System;

namespace W2D3T2
{
    internal class Program
    {
        static void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - i - 1; j++)
                    if (arr[j] > arr[j + 1])
                    {
                        // swap temp and arr[i]
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
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
            int[] arr = { 5, 1, 4, 2, 8 };
            Console.Write("Unsorted Array: ");
            PrintArray(arr);

            BubbleSort(arr);
            Console.Write("Sorted Array: ");
            PrintArray(arr);
        }
    }
}
