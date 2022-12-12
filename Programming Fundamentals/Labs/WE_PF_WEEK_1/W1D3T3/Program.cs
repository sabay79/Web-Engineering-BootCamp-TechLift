using System;

namespace W1D3T3
{
    abstract class Book
    {
        public String title;
        public abstract void SetTitle(String s);
        public String GetTitle() { return title; }
    }
    class MyBook : Book
    {
        public override void SetTitle(String s) { title = s; }
    }
    internal class Program
    {
        static void Main()
        {
            MyBook new_novel = new MyBook();
            new_novel.SetTitle("Rich Dad, Poor Dad");
            Console.WriteLine("Book Title: " + new_novel.GetTitle());
        }
    }
}
