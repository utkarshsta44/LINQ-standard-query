using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class AnyAll
    {
        public static void Method()
        {
            List<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "Utkarsh", Age = 21 } ,
                new Student() { StudentID = 2, StudentName = "govind",  Age = 22 } ,
                new Student() { StudentID = 3, StudentName = "prince",  Age = 22 } ,
                new Student() { StudentID = 4, StudentName = "ajay" , Age = 22 } ,
                new Student() { StudentID = 5, StudentName = "yash" , Age = 22 }
            };

            bool areAllStudentTeenAger = studentList.All(s => s.Age >= 20 && s.Age <= 23);
            Console.WriteLine(areAllStudentTeenAger);

           

        }
    }
}