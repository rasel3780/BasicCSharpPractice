using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Example1
{
    internal class Participant
    {
        public string Name { get; set; }
        public string PersonalContact { get; set; }
        public List<Course> EnrolledCourseList { get; set; }

        public Participant()
        {
            EnrolledCourseList = new List<Course>();
        }

        public void Enroll(Course course)
        {
            EnrolledCourseList.Add(course);
        }

        public virtual double GetTotalPayable()
        {
            double total = 0;
            foreach (var course in EnrolledCourseList) 
            {
                total += course.Fee;
            }
            return total;
        }
    }
}
