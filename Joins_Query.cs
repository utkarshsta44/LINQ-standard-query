using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Standard
    {
        public int ID { get; set; }
        public string StandardName { get; set; }
    }
    class Joins
    {
        public static void Method()
        {
            List<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "utkarsh", ID =1 },
                new Student() { StudentID = 2, StudentName = "yash", ID =1 },
                new Student() { StudentID = 3, StudentName = "prince", ID =2 },
                new Student() { StudentID = 4, StudentName = "ajay" , ID =2 },
                new Student() { StudentID = 5, StudentName = "govind" ,ID =3 }
            };

            List<Standard> standardList = new List<Standard>() {
                new Standard() { ID = 1, StandardName = "Standard 1"},
                new Standard() { ID = 2, StandardName = "Standard 2"},
                new Standard() { ID = 3, StandardName = "Standard 3"}
            };


            var joinResult = studentList.Join(standardList,
                    student => student.ID,
                    standard => standard.ID,
                    (student, standard) => new
                    {
                        StudentName = student.StudentName,
                        StandardName = standard.StandardName
                    });


            foreach (var item in joinResult)
            {
                Console.WriteLine(item.StudentName + ", " + item.StandardName);
            }
        }
    }
}