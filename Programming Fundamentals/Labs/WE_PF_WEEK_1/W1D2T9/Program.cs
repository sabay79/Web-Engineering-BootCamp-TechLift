//Migratory Birds
/*Given an array of bird sightings where every element represents a bird type id, 
 * determine the id of the most frequently sighted type. 
 * If more than 1 type has been spotted that maximum amount, 
 * return the smallest of their ids.*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace W1D2T9
{
    internal class Program
    {
        public static int MigratoryBirds(List<int> arr)
        {
            int[] birdCounts = new int[6];

            foreach (var type in arr)
                birdCounts[type]++;

            int maxValue = birdCounts.Max();
            int maxType = birdCounts.ToList().IndexOf(maxValue);

            return maxType;
        }
        static void Main()
        {
            Console.WriteLine("Enter no of birds sighted:");
            int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

            Console.WriteLine("Enter type # of the bird sighted:");
            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            Console.WriteLine("The lowest type id of the most frequently sighted birds: " + MigratoryBirds(arr));
        }
    }
}
