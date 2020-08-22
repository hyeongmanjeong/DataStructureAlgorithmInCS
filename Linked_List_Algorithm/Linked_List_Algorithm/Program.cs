using System;

namespace Linked_List_Algorithm
{
    public class Node
    {
        public int Data { get; set; }
        public Node Next = null;
    }
    class Program
    {
        private static Node linkedList = new Node();
        static void Main(string[] args)
        {
            Console.WriteLine("---- Print Linked List Start ----");
            Insert(linkedList,0,77);
            PrintLinkedList(linkedList);
            Insert(linkedList, 0, 4);
            PrintLinkedList(linkedList);
            Insert(linkedList, 0, 39);
            PrintLinkedList(linkedList);
            Insert(linkedList, 1, 1);
            Insert(linkedList, 2, 10);
            Insert(linkedList, 1, 80);
            PrintLinkedList(linkedList);
            Remove(linkedList, 1);
            Remove(linkedList, 2);
            PrintLinkedList(linkedList);
            Console.WriteLine("---- Print Linked List End ----");
        }
        public static void PrintLinkedList(Node list)
        {
            Console.Write(" ");
            while (list.Next != null)
            {
                list = list.Next;
                Console.Write($" {list.Data} -> ");
            }
            Console.WriteLine(" null ");
        }
        public static void Insert(Node list,int index,int data)
        {
            Node newNode = new Node();
            newNode.Data = data;
            Node prev = GetNode(list, index);
            Node current = prev.Next;

            prev.Next = newNode;
            newNode.Next = current;
        }
        public static void Remove(Node list,int index)
        {
            Node prevNode = GetNode(list, index);

            Node nodeToDelete = prevNode.Next;
            Node nextNode = nodeToDelete.Next;
            nodeToDelete = null;
            prevNode.Next = nextNode;
        }
        public static Node GetNode(Node list, int index)
        {
            Node next = list;
            for (int i = 0; i < index; i++)
            {
                next = next.Next;
            }
            return next;
        } 
    }    
}
