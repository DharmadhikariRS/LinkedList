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
    }
}
