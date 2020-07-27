using System;
using System.Collections.Generic;
using System.Text;

namespace Singly_Linked_List
{
    class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Employee(string firstName,string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string To_String()
        {
            return "FirstName : " + FirstName + " / " + "LastName : " + LastName;
        }
    }
}
