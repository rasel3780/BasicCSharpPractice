using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOfObject
{
    internal class Employee
    {
        public string Name { get; set; }
        public string Email {  get; set; }
        public string ContactNo { get; set; }

        public Employee()
        { 
        
        }

        public Employee(string name, string email, string contactNo):this() 
        {
            Name = name;
            Email = email;
            ContactNo = contactNo;
        }
    }
}
