using System;

namespace Linear_Search_Binary_Search
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, 4, 50, 9, 14, 17, 13 , 30,22,21 };

            Console.WriteLine(LinearSearching(arr, 10));
            Console.WriteLine(LinearSearching(arr, 99));

        }
        public static int LinearSearching(int[] arr,int value)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i] == value)
                { 
                    return i;
                }
            }
            return -1;
        }
    }
}
