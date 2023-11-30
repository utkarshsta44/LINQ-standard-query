using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Intersect
    {
        public static void Method()
        {
            List<Student> studentList1 = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "utkarsh", Age = 18 } ,
                new Student() { StudentID = 2, StudentName = "yash",  Age = 15 } ,
                new Student() { StudentID = 3, StudentName = "govind",  Age = 25 } ,
                new Student() { StudentID = 5, StudentName = "prince" , Age = 19 }
            };

            List<Student> studentList2 = new List<Student>() {
                new Student() { StudentID = 4, StudentName = "AJAY",  Age = 25 } ,
                new Student() { StudentID = 3, StudentName = "GOVIND" , Age = 19 },
                new Student() { StudentID = 6, StudentName = "aryan", Age = 20}
            };

            var intersectionStudents = studentList1.Intersect(studentList2, new StudentComparer());
            foreach (var item in intersectionStudents)
            {
                Console.WriteLine("StudentID : {0}, StudentName : {1}, Age : {2}", item.StudentID, item.StudentName, item.Age);
            }
        }
    }
}