using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            Student myStudent = new Student("Sarah", 8, 14);
            Student myStudent2 = new Student("George", 9, 22);

            ClassRoom myClassRoom = new ClassRoom();
            myClassRoom.ClassName = "ComputerScience";
            myClassRoom.SemesterStart = DateTime.Today;



            List<Student> myClassMates = new List<Student>();

            myClassMates.Add(myStudent);
            myClassMates.Add(myStudent2);
            //Console.WriteLine(myClassMates.Count());


            Student.CountBythMonthBySeason(myClassMates);
            //Student.Season(12);


            //Console.WriteLine(Student.Season(12));
            //Console.WriteLine(Student.Season(6));
            //Console.WriteLine("You were born in {0}", Student.Season(12));

            Console.ReadLine();
        }
    }
}
