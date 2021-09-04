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
            #region Instantiating Objects
            ClassRoom myClassRoom = new ClassRoom();
            myClassRoom.ClassName = "ComputerScience";
            myClassRoom.SemesterStart = new DateTime(2021, 08, 14);
            //myClassRoom.SemesterStart = DateTime.Today;


            Student myStudent1 = new Student("Sarah", 1, 14);
            Student myStudent2 = new Student("George", 2, 22);
            Student myStudent3 = new Student("Adriana", 3, 12);
            Student myStudent4 = new Student("Nohley", 4, 1);
            Student myStudent5 = new Student("Zarah", 5, 14);
            Student myStudent6 = new Student("Keorge", 6, 22);
            Student myStudent7 = new Student("Edriana", 7, 12);
            Student myStudent8 = new Student("Bohley", 8, 1);
            Student myStudent9 = new Student("Sarah", 9, 14);
            Student myStudent10 = new Student("George", 10, 22);
            Student myStudent11 = new Student("Adriana", 11, 12);
            Student myStudent12 = new Student("Nohley", 12, 1);
            Student myStudent13 = new Student("Zarah", 1, 14);
            Student myStudent14 = new Student("Keorge", 2, 22);
            Student myStudent15 = new Student("Edriana", 3, 12);
            Student myStudent16 = new Student("Bohley", 4, 1);

            //This line should throw an exception as the birth month should only be between 1 and 12
            //myStudent10.BirthMonth = 14;
            //Console.WriteLine(myStudent14.BirthMonth);

            #endregion

            #region  Adding the students into a list
            List<Student> myClassMatesList = new List<Student>();
            myClassMatesList.Add(myStudent1);
            myClassMatesList.Add(myStudent2);
            myClassMatesList.Add(myStudent3);
            myClassMatesList.Add(myStudent4);
            myClassMatesList.Add(myStudent5);
            myClassMatesList.Add(myStudent6);
            myClassMatesList.Add(myStudent7);
            myClassMatesList.Add(myStudent8);
            myClassMatesList.Add(myStudent9);
            myClassMatesList.Add(myStudent10);
            myClassMatesList.Add(myStudent11);
            myClassMatesList.Add(myStudent12);
            myClassMatesList.Add(myStudent13);
            myClassMatesList.Add(myStudent14);
            myClassMatesList.Add(myStudent15);
            myClassMatesList.Add(myStudent16);
            #endregion

            #region Writing to the console
            Console.WriteLine("Printing out the details of the number of students");
            Console.WriteLine("________________________________________________________________");
            //Task 4. Print out the information on your classroom 
            Console.WriteLine("ClassRoom = {0}", myClassRoom.ClassName);
            Console.WriteLine("Semester start = {0}", myClassRoom.SemesterStart);
            Console.WriteLine();

            foreach (Student student in myClassMatesList)
            {
                Console.WriteLine(student.ToString());
                //Console.WriteLine("Name = {0} , BirthMonth = {1}, BirthDay = {2}", student.Name, student.BirthMonth, student.Birthday);
            }

            Console.WriteLine("The total number of students = {0} ", myClassMatesList.Count());

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("What season is this birthday?");
            Console.WriteLine("________________________________________________________________");
            string seasonOfBirth = Student.Season2(12);
            Console.WriteLine("Your birthday is during the - {0}", seasonOfBirth);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("How many birthdays are there in these seasons");
            Console.WriteLine("________________________________________________________________");


            Student.CountBythMonthBySeason(myClassMatesList);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Using the second season method");



            Student.Season(12);
            Console.WriteLine(Student.Season(12));
            Console.WriteLine(Student.Season(6));
            Console.WriteLine("You were born in {0}", Student.Season(12));
            #endregion



            Console.ReadLine();
        }
    }
}
