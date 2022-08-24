using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class LinkedList
    {
        internal Node Head = null;
        internal Node Tail = null;

        internal void AddLast(int Data)
        {
            Node node = new Node(Data);
            if (Head == null)
            {
                Head = node;
                //    Tail=Head;
                Console.WriteLine("added " + Head.data);
            }
            else
            {
                Node temp = Head;
                while (temp.Next != null)
                {

                    temp = temp.Next;

                }

                temp.Next = node;
                Console.WriteLine("added " + temp.Next.data);
                //     Tail = temp;
            }
        }
        internal void Display()
        {
            Node temp = Head;
            Console.WriteLine("List Elements are:");
            while (temp != null)
            {
                Console.Write("{0} ", temp.data);
                temp = temp.Next;

            }
            Console.WriteLine();
        }

        internal void AddFirst(int Data)
        {
            Node node = new Node(Data);
            if (Head == null)
            {
                Head = node;
                //    Tail=Head;
                Console.WriteLine("added " + Head.data);
            }
            else
            {
                Node temp = node;
                temp.Next = Head;
                Head = temp;
                Console.WriteLine("added " + Head.data);
            }

        }
        internal void InsertInBetween(int Data, int firstNum)
        {
            Node node = new Node(Data);
            Node temp1 = Head;

            while (temp1.data != firstNum)
            {
                temp1 = temp1.Next;
            }
            node.Next = temp1.Next;
            temp1.Next = node;

            Console.WriteLine("{0} added after {1} ", node.data, firstNum);
        }
        internal void DeleteFirst()
        {
            if (Head == null)
            {
                Console.WriteLine("List is Empty");
            }
            else
            {
                Head = Head.Next;
                Console.WriteLine("First num deleted");
            }
        }
        internal void DeleteLast()
        {
            Node temp = Head;
            while (temp.Next.Next != null)
            {
                temp = temp.Next;
            }
            temp.Next = null;
            Console.WriteLine("Last num deleted");
        }
        internal void SearchElement(int Element)
        {
            
            int count = 0;
            Node temp = Head;

            while (temp != null)
            {
                count++;
                if (temp.data == Element)
                {
                    Console.WriteLine();

                    Console.WriteLine("{0} Found at position {1}", temp.data, count);
                    break;
                }

                temp = temp.Next;

            }
        }
        internal void DeleteCertainNum(int Element)
        {
            Node temp = Head;
            while (temp.Next.data != Element)
            {
                temp = temp.Next;
            }
            temp.Next = temp.Next.Next;
            Console.WriteLine("Deleted element {0} ", Element);
        }
    }
}
