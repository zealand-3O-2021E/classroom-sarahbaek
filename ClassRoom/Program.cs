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
            Student myStudent3 = new Student("Adriana", 3, 12);
            Student myStudent4 = new Student("Nohley", 1, 1);

            ClassRoom myClassRoom = new ClassRoom();
            myClassRoom.ClassName = "ComputerScience";
            myClassRoom.SemesterStart = DateTime.Today;



            List<Student> myClassMatesList = new List<Student>();

            myClassMatesList.Add(myStudent);
            myClassMatesList.Add(myStudent2);
            myClassMatesList.Add(myStudent3);
            myClassMatesList.Add(myStudent4);

            //Task 4. Print out the information on your classroom 
            foreach (Student student in myClassMatesList)
            {
                Console.WriteLine("Name = {0} , BirthMonth = {1}, BirthDay = {2}", student.Name, student.BirthMonth, student.Birthday);
            }

            Console.WriteLine("The total number of students = {0} ", myClassMatesList.Count());


            //Student.CountBythMonthBySeason(myClassMates);
            ////Student.Season(12);


            ////Console.WriteLine(Student.Season(12));
            ////Console.WriteLine(Student.Season(6));
            //Console.WriteLine("You were born in {0}", Student.Season(12));

            Console.ReadLine();
        }
    }
}
