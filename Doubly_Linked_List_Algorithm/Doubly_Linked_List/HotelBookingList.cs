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
            head = node;
            size++;
        }

    }
}
