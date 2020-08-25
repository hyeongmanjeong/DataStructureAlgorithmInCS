using System;

namespace Queue
{
    class Program
    {
        private static int[] queue = new int[50];
        private static int front = 0;
        private static int rear = 0;
        static void Main(string[] args)
        {
            Push(10);
            Push(18);
            Push(20);
            Push(33);
            PrintQueueArray();
            Pop();
            Pop();
            PrintQueueArray();
        }
        private static void PrintQueueArray()
        {
            Console.WriteLine(" ----- queue -----");
            for(int i = front; i < rear; i++)
            {
                Console.Write($" {queue[i]} -> ");
            }
            Console.WriteLine();
        }
        private static void Push(int data)
        {
            queue[rear] = data;
            rear++;
        }
        private static void Pop()
        {
            front++;
        }
        private static bool IsEmpty()
        {
            return front == rear;
        }
    }
}
