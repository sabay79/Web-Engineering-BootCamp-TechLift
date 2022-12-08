//Linear Search Algorithm

using System;
using System.Collections.Generic;

namespace W2D2T1
{
    class LinearSearch
    {
        public List<int> arr = new List<int>() { 2, 4, 6, 8, 10 };
        public int k = 6; //search element

        public void Search()
        {
            int left = 0;
            int length = arr.Count;
            int right = length - 1;
            int position = -1;

            // run loop from 0 to right
            for (left = 0; left <= right;)
            {
                // if search_element is found with left variable
                if (arr[left] == k)
                {
                    position = left;
                    Console.WriteLine(
                    "Element found in Array at "
                    + (position + 1) + " Position with "
                    + (left + 1) + " Attempt");
                    break;
                }
                // if search_element is found with right variable
                if (arr[right] == k)
                {
                    position = right;
                    Console.WriteLine(
                    "Element found in Array at "
                    + (position + 1) + " Position with "
                    + (length - right) + " Attempt");
                    break;
                }
                left++;
                right--;
            }
            // if element not found
            if (position == -1)
                Console.WriteLine("Not found in Array with "
                + left + " Attempt");
        }
    }
    internal class Program
    {
        static void Main()
        {
            LinearSearch lsVar = new LinearSearch();
            lsVar.Search();
        }
    }
}
