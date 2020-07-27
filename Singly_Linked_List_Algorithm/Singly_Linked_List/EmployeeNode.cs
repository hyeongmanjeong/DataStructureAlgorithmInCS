using System;
using System.Collections.Generic;
using System.Text;

namespace Singly_Linked_List
{
    class EmployeeNode
    {
        private Employee employee;
        private EmployeeNode next;

        public EmployeeNode(Employee e)
        {
            this.employee = e;
        }
        public Employee Employee { get { return employee; } set { employee = value; } }
        public EmployeeNode EmployeeNext { get { return next; } set { next = value; } }

        public string To_String()
        {
            return employee.To_String();
        }
    }
}
