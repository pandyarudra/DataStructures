using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Classes
{
    public class LinkedList
    {
        public Node first; // head
        public Node last; // tail

        public LinkedList(Node first) 
        {
            this.first = first;
            var current = first;
            do
            {
                if (current.next == null)
                {
                    last = current;
                }
                current = current.next;
            }
            while (current != null);
        }

        public Node AddFirst(int val)
        {
            var newNode = new Node(val, first.next);
            first = newNode;

            return newNode;
        }

        public Node AddLast(int val)
        {
            var newNode = new Node(val, null);
            last.next = newNode;       

            return newNode;
        }

        public void DeleteFirst()
        {
            first = first.next;
        }

        public void DeleteLast()
        {
            var current = first;
            do
            {   // get last second node to assign next
                if (current.next.next == null)
                {
                    current.next = null;
                    last = current;
                }
            } while (current.next.next != null);
        }

        public int IndexOf(int val)
        {
            var index = 0;
            var current = first;
            while (current.val != val)
            {
                if (val == current.val)
                {
                    break;
                } 
                else
                {
                    current = current.next;
                    index++;
                }
            }
            return index;
        }

        public bool Contains(int val)
        {
            var current = first;
            var valueFound = false;
            while (current != null && valueFound != true)
            {
                if (current.val == val)
                {
                    valueFound = true;
                    break;
                }
                current = current.next;
            }

            return valueFound;
        }

        public void Print()
        {
            var current = first;
            do
            {
                Console.WriteLine(current.val + "\n");
                current = current.next;
            } while (current != null);
        }
    }

    public class Node
    {
        public int val;
        public Node next;

        public Node(int val, Node next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}
