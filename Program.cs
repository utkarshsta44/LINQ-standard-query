﻿﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
        public int ID { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
           // Aggregate.Method();
            //Joins.Method();
            //AnyAll.Method();
            
            //Distinct.Method();
           
            //Except.Method();
            Intersect.Method();
            

            Console.ReadKey();
        }
    }
}