using System;
using System.Collections.Generic;


namespace GradeBook
{
  public  class Book
    {
        public Book(string name)
        {
            grades = new List<double>();
            Name = name;
        }

        public bool AddGrade(double grade)
        {
            if(grade<= 100 && grade >= 0)
            {
           grades.Add(grade);
//If GradeAdded is null it means nobody is listening, Noone cared enough to add a method reference into my delegate
//So I dont need to announce to anybody that a grade was added
if(GradeAdded!=null)
{

GradeAdded(this,new EventArgs());
}


           return true;
            }else{
return false;

            }
 
        }

        public Statistics GetStatistics()
        {


         var result = new Statistics();
         result.Average = 0.0;
         result.High = double.MinValue;
         result.Low = double.MaxValue;

         foreach(var grade in grades)
         {

             result.Low = Math.Min(grade,result.Low);
             result.High = Math.Max(grade,result.High);
             result.Average += grade;

         }
         result.Average/=grades.Count;

         return result;
        }

public string Name{
    get;
    set;
}

        private List<double> grades;
        // public string Name;

        public event GradeAddedDelegate GradeAdded;
    }
}