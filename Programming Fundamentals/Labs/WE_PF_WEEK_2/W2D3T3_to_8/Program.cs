using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W2D3T3_to_8
{
    internal class Program
    {
        static void Main()
        {
            SinglyLinkedList sList = new SinglyLinkedList();
            SinglyLinkedListNode Node1 = new SinglyLinkedListNode(22);
            SinglyLinkedListNode Node2 = new SinglyLinkedListNode(11);
            SinglyLinkedListNode Node3 = new SinglyLinkedListNode(33);
            SinglyLinkedListNode Node4 = new SinglyLinkedListNode(44);
            SinglyLinkedListNode Node5 = new SinglyLinkedListNode(55);

            Console.WriteLine("===============================");
            Console.WriteLine("6-6-Lab Questions - Linked List");
            Console.WriteLine("===============================");

            Console.WriteLine("\n---------");
            Console.WriteLine("INSERTION");
            Console.WriteLine("---------");

            Console.Write("\nAt the Head:");
            sList.InsertAtStart(Node1);
            sList.InsertAtStart(Node2);

            Console.Write("\n\nAt the Tail:");
            sList.InsertAtEnd(Node4);
            sList.InsertAtEnd(Node5);

            Console.Write("\n\nAt a specific Position:");
            sList.InsertAfter(Node3, 22);

            Console.WriteLine("\n\n-------");
            Console.WriteLine("REVERSE");
            Console.WriteLine("-------");
            sList.Reverse();

            Console.WriteLine("\n\n--------");
            Console.WriteLine("DELETION");
            Console.WriteLine("--------");

            Console.Write("\nAt the Head: ");
            sList.DeleteFromStart();

            Console.Write("\n\nAt the Tail: ");
            sList.DeleteFromEnd();

            Console.Write("\n\nAt specific Position: ");
            sList.DeleteAfter(33);

            Console.WriteLine("\n");
        }
    }
}
