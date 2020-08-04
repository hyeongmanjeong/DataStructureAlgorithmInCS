using System;
using System.Collections.Generic;
using System.Text;

namespace Doubly_Linked_List
{
    class HotelBooking
    {
        public int RoomNumber { get; set; }
        public string CheckInDay { get; set; }
        public string CheckOutDay { get; set; }

        public HotelBooking(int roomNum,string checkIn,string checkOut)
        {
            this.RoomNumber = roomNum;
            this.CheckInDay = checkIn;
            this.CheckOutDay = checkOut;
        }

        public string To_String()
        {
            return " Room Number : " + RoomNumber + " CheckInDay : " + CheckInDay + " CheckOutDay : " + CheckOutDay;
        }
    }
}
