using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Association_Relationship_One_To_One_Example2
{
    internal class Employee
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public Salary EmpSalary { get; set; }
    }
}
