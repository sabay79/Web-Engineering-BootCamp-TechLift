//You are in charge of the cake for a child's birthday.
//You have decided the cake will have one candle for each year of their total age.
//They will only be able to blow out the tallest of the candles.
//Count how many candles are tallest.

using System;
using System.Collections.Generic;
using System.Linq;

namespace W1D2T7
{
    internal class Program
    {
        public static int BirthdayCakeCandles(int n, List<int> candles)
        {
            int maxHeight = 0;
            int maxHeightCandles = 0;

            for (int i = 0; i < n; i++)
            {
                if (candles[i] > maxHeight)
                {
                    maxHeight = candles[i];
                    maxHeightCandles = 1;
                }
                else if (candles[i] == maxHeight)
                {
                    maxHeightCandles++;
                }
            }
            return maxHeightCandles;
        }
        static void Main()
        {
            Console.WriteLine("Enter total candles:");
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            Console.WriteLine("Enter height(space-seperated) of candles:");
            List<int> candles = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(candlesTemp => Convert.ToInt32(candlesTemp)).ToList();

            int result = BirthdayCakeCandles(n, candles);

            Console.WriteLine("No. of tallest candle(s): " + result);
        }
    }
}
