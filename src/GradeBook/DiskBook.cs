using System;
using System.IO;

namespace GradeBook
{
    public class DiskBook : Book
    {
        public DiskBook(string name) : base(name)
        {
        }

        public override event GradeAddedDelegate GradeAdded;

        public override bool AddGrade(double grade)
        {
            //using cleans up all it uses at the end, basically it generate a try,finally statement 
            //This is a pattern you will se on c# when working with files, Sockets
            using (var objFile = File.AppendText($"{Name}.txt"))
            {
                objFile.WriteLine(grade);
            }

            //If GradeAdded is null it means nobody is listening, Noone cared enough to add a method reference into my delegate
            //So I dont need to announce to anybody that a grade was added
            if (GradeAdded != null)
            {

                //This line is like say to the delegate:
                //Stay here waiting until some variable point to you baby
                GradeAdded(this, new EventArgs());
            }
            return true;

        }

        public override Statistics GetStatistics()
        {
            var result = new Statistics();
            using (var reader = File.OpenText($"{Name}.txt"))
            {
                var line = reader.ReadLine();
                while (line != null)
                {
                    var number = double.Parse(line);
                    result.Add(number);
                    line = reader.ReadLine();
                }
            }
            return result;
        }
    }
}