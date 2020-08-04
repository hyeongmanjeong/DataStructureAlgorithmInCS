using System;
using System.Collections.Generic;
using System.Text;

namespace Doubly_Linked_List
{
    class HotelBookingList
    {
        private HotelBookingNode head;
        private HotelBookingNode tail;
        private int size;

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
        public void PrintAllLinkedList()
        {
            HotelBookingNode current = head;
            Console.Write("Head -> ");
            while (current.Next != null)
            {
                Console.Write($"{current.To_String()} -> ");
                current = current.Next;
            }
            Console.WriteLine("Tail");
        }

    }
}
