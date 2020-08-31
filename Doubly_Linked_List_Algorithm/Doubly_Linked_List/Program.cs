using System;

namespace Doubly_Linked_List
{
    class Program
    {
        static void Main(string[] args)
        {
            HotelBooking info1 = new HotelBooking(301,"10/10/2020", "15/10/2020");
            HotelBooking info2 = new HotelBooking(302, "11/10/2020", "13/10/2020");
            HotelBooking info3 = new HotelBooking(303, "9/10/2020", "14/10/2020");
            HotelBooking info4 = new HotelBooking(304, "13/10/2020", "17/10/2020");

            HotelBookingList reservationByHyeongman = new HotelBookingList();

            reservationByHyeongman.AddToFront(info1);
            reservationByHyeongman.AddToFront(info2);
            reservationByHyeongman.AddToFront(info3);
            reservationByHyeongman.AddToFront(info4);


            reservationByHyeongman.PrintAllLinkedList();
            Console.WriteLine($"Linked List Current Size : {reservationByHyeongman.size}");
            HotelBooking info5 = new HotelBooking(305, "13/10/2020", "17/10/2020");
            reservationByHyeongman.AddToEnd(info5);
            reservationByHyeongman.PrintAllLinkedList();
            Console.WriteLine($"Linked List Current Size : {reservationByHyeongman.size}");
            reservationByHyeongman.RemoveIndexFromFront();
            reservationByHyeongman.PrintAllLinkedList();
            Console.WriteLine($"Linked List Current Size : {reservationByHyeongman.size}");
            reservationByHyeongman.RemoveIndexFromEnd();
            reservationByHyeongman.PrintAllLinkedList();
            Console.WriteLine($"Linked List Current Size : {reservationByHyeongman.size}");
        }
    }
}
