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
    class Stacks
    {
        Node top;

        public Stack()
        {
            top = null;
        }

        bool empty()
        {
            if (top == null)
                return (true);
            else
                return (false);
        }
        public void push(char[] element)
        {
            Node fresh;
            fresh = new Node(element, null);

            fresh.next = top;
            top = fresh;
            Console.WriteLine("\n" + element + " pushed.");
        }
        public void pop()

    }
}
