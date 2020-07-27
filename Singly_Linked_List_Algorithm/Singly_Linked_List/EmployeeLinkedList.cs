using System;
using System.Collections.Generic;
using System.Text;

namespace Singly_Linked_List
{
    class EmployeeLinkedList
    {
        private EmployeeNode head;
        

        public void AddToFront(Employee e)
        {
            EmployeeNode node = new EmployeeNode(e);

            node.EmployeeNext = head;
            head = node;

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
