using System;

namespace Doubly_Linked_List
{
    class Program
    {
        static void Main(string[] args)
        {
            HotelBooking hayattHotel_1 = new HotelBooking(301,"10/10/2020", "15/10/2020");
            HotelBooking hayattHotel_2 = new HotelBooking(302, "11/10/2020", "13/10/2020");
            HotelBooking hayattHotel_3 = new HotelBooking(303, "9/10/2020", "14/10/2020");
            HotelBooking hayattHotel_4 = new HotelBooking(304, "13/10/2020", "17/10/2020");
            HotelBooking hayattHotel_5 = new HotelBooking(305, "8/10/2020", "12/10/2020");
            HotelBooking hayattHotel_6 = new HotelBooking(306, "12/10/2020", "16/10/2020");
            HotelBooking hayattHotel_7 = new HotelBooking(307, "14/10/2020", "18/10/2020");

            HotelBookingList reservationByHyeongman = new HotelBookingList();

            reservationByHyeongman.AddToFront(hayattHotel_1);
            reservationByHyeongman.AddToFront(hayattHotel_2);
            reservationByHyeongman.AddToFront(hayattHotel_3);
            reservationByHyeongman.AddToFront(hayattHotel_4);
            reservationByHyeongman.AddToFront(hayattHotel_5);
            reservationByHyeongman.AddToFront(hayattHotel_6);
            reservationByHyeongman.AddToFront(hayattHotel_7);


            reservationByHyeongman.PrintAllLinkedList();
        }
    }
}
