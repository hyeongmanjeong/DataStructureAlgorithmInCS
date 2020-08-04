using System;
using System.Collections.Generic;
using System.Text;

namespace Doubly_Linked_List
{
    class HotelBookingNode
    {
        public HotelBooking RoomNumber { get; set; }
        public HotelBookingNode Next { get; set; }
        public HotelBookingNode Prev { get; set; }

        public HotelBookingNode(HotelBooking h)
        {
            this.RoomNumber = h;
        }

        public string To_String()
        {
            return RoomNumber.To_String();
        }        
    }
}
