using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class Node
    {
        internal int data;
        internal Node Next;

        internal Node(int data)
        {
            this.data = data;
            Next = null;
        }
    }
}
