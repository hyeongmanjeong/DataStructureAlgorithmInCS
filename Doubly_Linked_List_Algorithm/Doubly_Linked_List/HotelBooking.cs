using System;
using System.Collections.Generic;
using System.Text;

namespace Doubly_Linked_List
{
    class HotelBooking
    {
        public int RoomNumber { get; set; }
        public int CheckInDay { get; set; }
        public int CheckOutDay { get; set; }


        public string To_String()
        {
            return "Room Number : " + RoomNumber + "CheckInDay : " + CheckInDay + "CheckOutDay : " + CheckOutDay;
        }
    }
}
