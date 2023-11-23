using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Overloading_Method_Constructor
{
    internal class Student
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        
        public Student()
        {
            Id = "Unknown";
            Name = "Unknown";
            Email = "Unknown";
        }

        public Student(string id, string name) : this()
        {
            Id = id;
            Name = name;
        }

        public Student(string id, string name, string email) : this(id, name) 
        {
            Email = email;
        }

        public void ShowInfo(string id)
        {
            Console.WriteLine($"Name:{Name}");
            Console.WriteLine("-----------------");
        }

        public void ShowInfo(bool showDetails)
        {
            if (showDetails)
            {
                Console.WriteLine($"Id:{Id}, Name:{Name}, Email:{Email}");
                Console.WriteLine("-----------------");
            }
        }
    }
}
