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


            Console.WriteLine("Enter a grade or 'q' to quit");
            var book = new InMemoryBook("Ines del alma mia");
            book.GradeAdded += OnGradeAdded;
            //book.GradeAdded-=OnGradeAddedToFile;//unsuscribe
            book.GradeAdded += OnGradeAddedToFile; //So here we are pointing to our delegate that is inisde book class
                                                   //and telling it, "listen to me baby"
                                                   //book.GradeAdded= OnGradeAdded;//we can't do direct assingments on delegates
                                                   //because if you asign it null for example, you will delete all the other that suscribe to this event
                                                   //This values  were for testing, before asking grades to user
                                                   // book.AddGrade(89.1);
                                                   // book.AddGrade(90.5);
                                                   // book.AddGrade(77.3);
            EnterGrades(book);

            var stats = book.GetStatistics();

            Console.WriteLine($"The lowest grade is {stats.Low}");
            Console.WriteLine($"The highest grade is {stats.High}");
            Console.WriteLine($"The average grade is {stats.Average:N1}");


        }

        private static void EnterGrades(IBook book)
        {
            while (true)
            {
                var input = Console.ReadLine();

                if (input == "q")
                {
                    break;
                }

                try
                {

                    var grade = double.Parse(input);
                    book.AddGrade(grade);

                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (FormatException ex) { Console.WriteLine(ex.Message); }
                finally
                {
                    Console.WriteLine("**");
                }


            }
        }


        //remember static members just can see another static members
        //Book Class has no idea about this method hea
        static void OnGradeAdded(object sender,EventArgs args)
        {
                        Console.WriteLine($"A grade was added");
        }

           static void OnGradeAddedToFile(object sender,EventArgs args)
        {
                        Console.WriteLine($"A grade was added and we wanna wirte that event in a file oh yeah");
        }
    }
}
