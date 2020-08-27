using System;
using System.Collections.Generic;
using System.Text;

namespace Doubly_Linked_List
{
    class HotelBookingList
    {
        private HotelBookingNode head;
        private HotelBookingNode tail;
        public int size;

        public void AddToFront(HotelBooking h)
        {
            HotelBookingNode node = new HotelBookingNode(h);
            node.Next = head;
            if(head == null)
            {
                tail = node;
            }
            else
            {
                head.Prev = node;
            }
            head = node;
            size++;
        }
        public void AddToEnd(HotelBooking h)
        {
            HotelBookingNode node = new HotelBookingNode(h);
            if (tail == null)
            {
                head = node;
            }
            else
            {
                tail.Next = node;
                node.Prev = tail;
            }
            tail = node;
            size++;
        }
        public void RemoveIndexFromFront()
        {
            if (IsEmpty())
            {
                return;
            }
            HotelBookingNode removeNode = head;
            head = head.Next;
            size--;
            removeNode = null;
        }
        public void RemoveIndexFromEnd()
        {

        }
        private bool IsEmpty()
        {
            return head == null;
        }
        public void PrintAllLinkedList()
        {
            HotelBookingNode current = head;
            Console.Write("Head -> ");
            while (current.Next != null)
            {
                Console.Write($" {current.To_String()} -> ");
                current = current.Next;
            }
            Console.WriteLine("Tail");
        }

    }
}
