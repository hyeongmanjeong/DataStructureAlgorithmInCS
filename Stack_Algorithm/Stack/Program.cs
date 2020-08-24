using System;

namespace Stack
{
    class Program
    {
        private static int[] stack = new int[10];
        private static int top = -1;
        static void Main(string[] args)
        {
            Push(200);
            Push(900);
            Push(223);
            PrintStackArray();
            Push(200);
            PrintStackArray();
            Pop();
            Pop();
            PrintStackArray();
        }
        private static bool IsEmpty()
        {
            return top == -1;
        }
        private static void Push(int data)
        {
            top++;
            stack[top] = data;
        }
        private static void Pop()
        {
            top--;
        }
        private static void PrintStackArray()
        {
            Console.WriteLine(" -------- Stack ---------");
            for (int i = 0; i < top + 1; i++)
            {
                Console.Write($" {stack[i]} -> ");
            }
            Console.WriteLine();
        }
    }
}
