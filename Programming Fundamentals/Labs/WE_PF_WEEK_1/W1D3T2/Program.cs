using System;

namespace W1D3T2
{
    internal class Arithematic
    {
        public int Add(int x, int y) { return x + y; }
    }
    internal class Adder : Arithematic {}
    internal class Program
    {
        static void Main()
        {
            Adder a = new Adder();
            Console.WriteLine("My superclass is: " + typeof(Adder).BaseType.Name);
            Console.WriteLine(a.Add(10, 32) + " " + a.Add(10, 3) + " " + a.Add(10, 10));
        }
    }
}
