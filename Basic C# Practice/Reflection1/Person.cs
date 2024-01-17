using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection1
{
    public class Person
    {
        public string Name { get; set; }
        private int Age { get; set; }

        public Person(int age)
        {
            Age = age;
        }
    }
}
