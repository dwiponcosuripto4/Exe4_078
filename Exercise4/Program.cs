using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class Node
    {
        public char[] ponco = new char[96];
        public Node next;
        public Node(char[] p, Node n)
        {
            ponco = p;
            next = n;
        }
    }
}
