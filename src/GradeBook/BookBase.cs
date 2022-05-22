namespace GradeBook
{ 

    public abstract class Book:NamedObject
    {

         public Book(string name):base(name)//this access the constructor of base class
        {
         
        }

        public abstract bool AddGrade(double grade);

    }
}