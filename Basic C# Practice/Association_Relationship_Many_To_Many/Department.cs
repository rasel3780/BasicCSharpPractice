using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Association_Relationship_Many_To_Many
{
    internal class Department
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public List<Student> StudentList { get; set; }
        public List<Course> CourseList { get; set; }
        public List<Enrollment> EnrollmentList { get; set; }

     

        public bool CourseTitleAlreadyTaken(string courseTitle)
        {
            foreach(Course course in CourseList)
            {
                if(course.Title==courseTitle) return true;
            }
            return false;
        }

        public bool StudentRegNoAlreadyTaken(string regNo)
        {
            foreach (Student student in StudentList)
            {
                if (student.RegNo==regNo) return true;
            }
            return false;
        }

        public Student StudentFinder(string regNo)
        {
            foreach(Student student in StudentList)
            {
                if(student.RegNo==regNo)
                    return student;
            }
            return null;
        }

        public Course CourseFinder(string courseName)
        {
            foreach(Course course in CourseList)
            {
                if(course.Title == courseName) return course;
            }
            return null;
        }
    }
}
