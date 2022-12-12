using System;

namespace W1D3T1
{
    class Animal
    {
        public void walk()
        {
            Console.WriteLine("I am walking");
        }
    }
    class Bird : Animal
    {
        public void fly()
        {
            Console.WriteLine("I am flying");
        }
        public void sing()
        {
            Console.WriteLine("I am singing");
        }
    }
    internal class Program
    {
        static void Main()
        {
            Bird bird = new Bird();
            bird.walk();
            bird.fly();
            bird.sing();
        }
    }
}
