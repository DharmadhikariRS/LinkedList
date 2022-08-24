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
    }
}
