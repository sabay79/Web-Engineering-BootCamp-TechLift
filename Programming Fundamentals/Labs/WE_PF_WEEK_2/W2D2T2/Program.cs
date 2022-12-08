//Binary Search Algorithm

using System;
using System.Collections.Generic;

namespace W2D2T2
{
    class BinarySearch
    {
        public List<int> arr = new List<int>() { 2, 4, 6, 8, 10 };
        public int k = 6; //search element

        public int Search()
        {
            int l = 0, r = arr.Count - 1;
            if (r >= l)
            {
                int mid = l + (r - l) / 2;

                // If the element is present at the middle itself
                if (arr[mid] == k)
                    return mid;

                // If element is smaller than mid, then
                // it can only be present in left subarray
                if (arr[mid] > k)
                    return Search();

                // Else the element can only be present
                // in right subarray
                return Search();
            }
            // We reach here when element is not present
            // in array
            return -1;

        }
    }

    internal class Program
    {
        static void Main()
        {
            BinarySearch bsVar = new BinarySearch();
            int result = bsVar.Search();

            if (result == -1)
                Console.WriteLine("Element not present");
            else
                Console.WriteLine("Element found at index "
                + result);
        }
    }
}
