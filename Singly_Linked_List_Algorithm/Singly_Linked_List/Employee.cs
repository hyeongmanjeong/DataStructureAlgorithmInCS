using System;
using System.Collections.Generic;
using System.Text;

namespace Singly_Linked_List
{
    class Employee
    {
        private string firstName;
        private string lastName;

        public string FirstName { get { return firstName; } set { firstName = value; } }
        public string LastName { get { return lastName; } set { lastName = value; } }

        public Employee(string firstName,string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string To_String()
        {
            return "FirstName : " + FirstName + " , " + "LastName : " + LastName;
        }
    }
}
