using System;

namespace W2D3T3_to_8
{
    public class SinglyLinkedList
    {
        public SinglyLinkedListNode head;

        public SinglyLinkedList()
        {
            this.head = null;
        }

        //INSERSION

        public void InsertAtStart(SinglyLinkedListNode newNode)
        {
            newNode.next = head; 
            head = newNode;

            this.Print();
        }

        public void InsertAtEnd(SinglyLinkedListNode newNode) 
        {
            SinglyLinkedListNode temp = head;
            while(temp.next != null)
                temp = temp.next; 
                
            temp.next = newNode;
            newNode.next = null;

            this.Print();
        }

        public void InsertAfter(SinglyLinkedListNode newNode, int target) 
        {
            SinglyLinkedListNode temp = head;

            while(temp.data != target)
                temp = temp.next;

            newNode.next = temp.next;
            temp.next = newNode;

            this.Print();
        }

        //DELETION

        public void DeleteFromStart() 
        {
            head = head.next;

            this.Print();

        }

        public void DeleteFromEnd() 
        {
            SinglyLinkedListNode temp = head;
            while(temp.next.next != null)
                temp = temp.next;

            temp.next = null;

            this.Print();
        }

        public void DeleteAfter(int target) 
        {
            SinglyLinkedListNode temp = head;

            while (temp.data != target)
                temp = temp.next;

            temp.next = temp.next.next;

            this.Print();
        }

        //DISPLAY

        public void Print()
        {
            SinglyLinkedListNode temp = head;

            Console.Write("\n>> ");
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }

        //SEARCH

        public SinglyLinkedListNode Search(int target)
        {
            SinglyLinkedListNode temp = head;

            while (temp != null && temp.data != target)
                temp = temp.next;

            return temp;
        }

        //REVERSE

        public void Reverse()
        {
            SinglyLinkedListNode prev = null;
            SinglyLinkedListNode current = head;
            while (current != null) 
            {
                SinglyLinkedListNode temp = current.next;
                current.next = prev;
                prev = current;
                current = temp;
            }
            head = prev;

            this.Print();
        }
    }
}
