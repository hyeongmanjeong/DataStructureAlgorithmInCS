using System;

namespace Linear_Search_Binary_Search
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 4, 6, 9, 14, 17, 20 , 21,28,30 };

            // -1 아닐경우 성공 
            // Linear Searching  
            Console.WriteLine($"Found Index Of {LinearSearching(arr, 17)}");
            Console.WriteLine($"Found Index Of {LinearSearching(arr, 33)}");
            // Binary Searching
            Console.WriteLine($"Found Index Of {BinarySearching(arr, 9)}");
            Console.WriteLine($"Found Index Of {BinarySearching(arr, 22)}");
        }
        private static int LinearSearching(int[] arr,int value)
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
        private static int BinarySearching(int[] arr,int value) 
        {
            int start = 0;
            int end = arr.Length;
            while (start < end)
            {
                int midPoint = (start + end) / 2;
                if (arr[midPoint] == value)
                {
                    return midPoint;
                }
                else if (arr[midPoint] < value)
                {
                    start = midPoint + 1;
                }
                else
                {
                    end = midPoint;
                }
            }
            return -1;
        }
    }
}
