using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Association_Relationship_One_to_Many
{
    internal class Department
    {
        public string DepartmentName { get; set; }
        public string DepartmentCode { get; set; }
        
        public List<Student> StudentList = new List<Student>();
    }

}
