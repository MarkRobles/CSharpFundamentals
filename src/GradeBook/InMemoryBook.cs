using System;
using System.Collections.Generic;


namespace GradeBook
{
  public  class InMemoryBook:Book
    {
        public InMemoryBook(string name):base(name)//this access the constructor of base class
        {
            grades = new List<double>();
            Name = name;
        }

        public override bool AddGrade(double grade)
        {
            if(grade<= 100 && grade >= 0)
            {
           grades.Add(grade);
//If GradeAdded is null it means nobody is listening, Noone cared enough to add a method reference into my delegate
//So I dont need to announce to anybody that a grade was added
if(GradeAdded!=null)
{

//This line is like say to the delegate:
//Stay here waiting until some variable point to you baby
GradeAdded(this,new EventArgs());
}


           return true;
            }else{
return false;

            }
 
        }

        public override Statistics GetStatistics()
        {


         var result = new Statistics();
     
         foreach(var grade in grades)
         {
            result.Add(grade);

         }


         return result;
        }

        private List<double> grades;
        // public string Name;

        public override event GradeAddedDelegate GradeAdded;
    }
}