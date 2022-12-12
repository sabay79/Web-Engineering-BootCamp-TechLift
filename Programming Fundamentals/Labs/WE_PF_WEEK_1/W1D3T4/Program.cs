using System;

namespace W1D3T4
{
    internal interface IAdvancedArithematic
    {
        int divisor_sum(int n);
    }
    internal class MyCalculator : IAdvancedArithematic
    {
        public int divisor_sum(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0) sum += i;
            }
            return sum;
        }
    }
    internal class Program
    {
        static void Main()
        {
            MyCalculator my_calculator = new MyCalculator();
            Console.WriteLine("I implemented: " + typeof(IAdvancedArithematic).Name);

            int n = 8;
            Console.WriteLine("Sum of divisors of " + n + " is " + my_calculator.divisor_sum(n) + ".\n");
        }
    }
}
