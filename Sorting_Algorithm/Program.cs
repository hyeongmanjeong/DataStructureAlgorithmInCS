using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 10, 7, 1, 6, 8, 9, 2, 4 ,5,3};
            //  before sorting array
            PrintAllData(arr);
            Console.WriteLine(" ------------------------- ");
            //    Bubble_Sorting(arr);
            //    Selection_Sorting(arr);
            Insertion_Sorting(arr);
            Console.WriteLine(" ------------------------- ");
            //  after sorting array
            PrintAllData(arr);
        }
        private static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        private static void PrintAllData(int[] arr)
        {
            foreach (int n in arr)
            {
                Console.Write($"{n} -> ");
            }
            Console.WriteLine();
        }
        private static void Bubble_Sorting(int[] arr)
        {
            for (int i = arr.Length - 1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        Swap(ref arr[j],ref arr[j + 1]);
                        PrintAllData(arr);
                    }
                }
            }
        }
        private static void Selection_Sorting(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[min] > arr[j])
                    {
                        min = j;
                    }
                }
                Swap(ref arr[i], ref arr[min]);
                PrintAllData(arr);
            }
        }
        private static void Insertion_Sorting(int[] arr)
        {
            for(int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (arr[j] < arr[j - 1])
                    {
                        Swap(ref arr[j - 1], ref arr[j]);
                    }
                }
                PrintAllData(arr);
            }
        }
    }
}
