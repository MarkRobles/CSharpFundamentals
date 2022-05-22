namespace GradeBook
{ 

    public abstract class Book:NamedObject, IBook
    {

         public Book(string name):base(name)//this access the constructor of base class
        {
         
        }

        public virtual event GradeAddedDelegate GradeAdded;

        public  abstract bool AddGrade(double grade);

        public virtual Statistics GetStatistics()
        {
            throw new System.NotImplementedException();
        }
    }
}