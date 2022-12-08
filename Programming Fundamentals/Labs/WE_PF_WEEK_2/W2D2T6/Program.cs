//Bonus Task # 01
//Square root of Integer   

using System;

namespace W2D2T6
{
    class SquareRoot
    {
        public double num = 49;
        public double Sqrt()
        {
            // base case
            if (num == 0 || num == 1)
                return num;

            double start = 1, end = num, mid;

            while (start <= end)
            {
                mid = (start + end) / 2;

                //perfect square
                //sq(mid) = num
                if (mid * mid == num)
                    return mid;

                // sq(mid) > num
                else if (mid * mid > num)
                {
                    end = mid + 1;
                }

                // sq(mid) < num
                else
                    start = mid - 1;
            }
            return start;
        }
    }
    internal class Program
    {
        static void Main()
        {
            SquareRoot sqrt = new SquareRoot();
            Console.WriteLine("Square Root of {0}: {1}", sqrt.num, Math.Floor(sqrt.Sqrt()));
            //Console.WriteLine("Square Root of {0}: {1}", num, Math.Sqrt(num));
        }
    }
}
