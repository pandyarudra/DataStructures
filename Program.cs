using DataStructures.Classes;
using System;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstNode = new Node(10);
            firstNode.next = new Node(20);
            firstNode.next.next = new Node(30);
            firstNode.next.next.next = new Node(40);

            var linkedList = new LinkedList(firstNode);
            linkedList.DeleteFirst();
            linkedList.Print();
            Console.WriteLine(linkedList.Contains(10));
            Console.ReadKey();
        }
    }
}
