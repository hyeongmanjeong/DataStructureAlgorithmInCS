using System;

namespace Singly_Linked_List
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee hyeongman = new Employee("hyeongman","jeong");
            Employee yumi = new Employee("yumi", "pack");
            Employee iu = new Employee("Yuna", "kim");
            Employee yuee = new Employee("yui", "son");

            EmployeeLinkedList list = new EmployeeLinkedList();

            Console.WriteLine($"Linked List Is Empty ?  : {list.IsEmpty()}");
            Console.WriteLine();
            
            list.AddToFront(hyeongman);
            list.AddToFront(yumi);
            list.AddToFront(iu);
            list.AddToFront(yuee);

            list.PrintLinkedList();
            Console.WriteLine($"Linked List Size : {list.Size}");
            Console.WriteLine();
            Console.WriteLine("-- After Remove From First --");
            Console.WriteLine();
            list.RemoveFromFront();
            list.PrintLinkedList();
            Console.WriteLine($"Linked List Size : {list.Size}");
        }
    }
}
