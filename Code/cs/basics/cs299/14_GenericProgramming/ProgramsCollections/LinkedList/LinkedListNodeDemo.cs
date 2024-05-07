// LinkedListNodeDemo.cs - Basic operations on a LinkedList of 
// integers - using LinkedListNodes.

using System;
using System.Collections.Generic;

class LinkedListNodeDemo
{

    public static void Main()
    {

        LinkedList<int> lst = new LinkedList<int>(
                                   new int[] { 5, 3, 2, 7, -4, 0 });
        ReportList("Initial LinkedList", lst);

        LinkedListNode<int> node1, node2, node;
        node1 = lst.First;
        node2 = lst.Last;

        // Run-time error. 
        // The LinkedListNode is already in the list.
        // Error message: The LinkedList node belongs a LinkedList.
        /*   lst.AddLast(node1);   */

        // Move first node to last node in list
        lst.Remove(node1); lst.AddLast(node1);
        ReportList("node1 = lst.First; lst.Remove(node1); lst.AddLast(node1);", lst);

        // Navigate in list via LinkedListNode objects
        node1 = lst.First;
        Console.WriteLine("Third element in list: node1 = lst.First;  node1.Next.Next.Value    {0}\n",
                           node1.Next.Next.Value);

        // Add an integer after a LinkedListNode object
        lst.AddAfter(node1, 17);
        ReportList("lst.AddAfter(node1, 17);", lst);

        // Add a LinkedListNode object after another LinkedListNode object
        lst.AddAfter(node1, new LinkedListNode<int>(18));
        ReportList("lst.AddAfter(node1, new LinkedListNode<int>(18));", lst);

        // Navigate in LinkedListNode objects and add an int before a node:
        node = node1.Next.Next.Next;
        lst.AddBefore(node, 99);
        ReportList("node = node1.Next.Next.Next; lst.AddBefore(node, 99); ", lst);

        // Navigate in LinkedListNode objects and remove a node.
        node = node.Previous;
        lst.Remove(node);
        ReportList("node = node.Previous; lst.Remove(node);", lst);

    }

    public static void ReportList<T>(string explanation, LinkedList<T> list)
    {
        Console.WriteLine(explanation);
        foreach (T el in list)
            Console.Write("{0, 4}", el);
        Console.WriteLine(); Console.WriteLine();
    }

}
