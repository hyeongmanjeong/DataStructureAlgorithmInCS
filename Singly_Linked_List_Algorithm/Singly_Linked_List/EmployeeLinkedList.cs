using System;
using System.Collections.Generic;
using System.Text;

namespace Singly_Linked_List
{
    class EmployeeLinkedList
    {
        private EmployeeNode head = null;
        private int size;

        public int Size { get { return size; } set { size = value; } }
        public void AddToFront(Employee e)
        {
            EmployeeNode node = new EmployeeNode(e);

            node.EmployeeNext = head;
            head = node;
            Size++;
        }
        public EmployeeNode RemoveFromFront()
        {
            if (IsEmpty())
            {
                return null;
            }
            EmployeeNode removeNode = head;
            head = head.EmployeeNext;
            Size--;
            removeNode.EmployeeNext = null;
            return removeNode;
        }
        public bool IsEmpty()
        {
            return head == null;
        }
        public void PrintLinkedList()
        {
            EmployeeNode current = head;
            Console.Write("head - > ");
            while (current != null)
            {
                Console.Write(current.To_String());
                Console.Write("   ->   ");
                current = current.EmployeeNext;
            }
            Console.WriteLine(" null ");
        }


    }
}
