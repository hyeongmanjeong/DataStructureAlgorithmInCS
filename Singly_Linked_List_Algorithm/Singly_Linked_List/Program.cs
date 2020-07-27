using System;

namespace Singly_Linked_List
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee hyeongman = new Employee("hyeongman","jeong");
            Employee yumi = new Employee("yumi", "pack");
            Employee iu = new Employee("eeYu", "kim");
            Employee yuee = new Employee("yuee", "son");

            EmployeeLinkedList list = new EmployeeLinkedList();
            list.AddToFront(hyeongman);
            list.AddToFront(yumi);
            list.AddToFront(iu);
            list.AddToFront(yuee);

            list.PrintLinkedList();

        }
    }
}
