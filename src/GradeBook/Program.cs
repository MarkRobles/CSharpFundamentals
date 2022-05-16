using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {

        //To know if a type is a value or reference type is easy. 
        //Go to the definition of a type with f12, for example int type.
//string type is referece type but behaves as a value type
        //All types that are a class  are referece types 
        //All types that a a struct a value types
        static void Main(string[] args)
        {               

            var book = new Book("Scott's Grade Book");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.3);

            var stats = book.GetStatistics();
 


            Console.WriteLine($"The lowest grade is {stats.Low}");
            Console.WriteLine($"The highest grade is {stats.High}");
            Console.WriteLine($"The average grade is {stats.Average:N1}");

        }        
    }
}
