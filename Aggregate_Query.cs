using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Aggregate
    {
        public static void Method()
        {
            List<int> array1 = new List<int>() { 1,2,3,4,5,6 };


            Console.WriteLine("Maximum element: {0}", array1.Max());
            Console.WriteLine("Minimum element: {0}", array1.Min());

            Console.WriteLine("Sum : {0}",array1.Sum());
            Console.WriteLine("Count of elements  : {0}", array1.Count());
            Console.WriteLine("Average of elements  : {0}", array1.Average());

        
        }
    }
}