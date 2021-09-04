﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    public class Student
    {
        private string _name;
        private int _birthMonth;
        private int _birthday;

        public Student(string name, int birthMonth, int birthday)
        {
            this.Name = name;
            this.BirthMonth = birthMonth;
            this.Birthday = birthday;
        }

        public string Name { get => _name; set => _name = value; }
        public int BirthMonth { get => _birthMonth; set => _birthMonth = value; }
        public int Birthday { get => _birthday; set => _birthday = value; }

        public static string Season2(int birthMonth)
        {
            string Winter;
            string Spring;
            string Summer;
            string Autumn;
            string strSeason;


            switch (birthMonth)
            {
                case 1:
                case 2:
                case 12:
                    return strSeason = "Winter";
                    break;

                case 3:
                case 4:
                case 5:
                    return strSeason="Spring";
                    break;

                case 6:
                case 7:
                case 8:
                    return strSeason="Summer";
                    break;


                case 9:
                case 10:
                case 11:
                    return strSeason = "Autumn";
                    break;


                default:
                    strSeason = "unknown";
                    Console.WriteLine("The bithrday months are between 1 - 12 , please enter a number in this range");
                    break;
            }

            return strSeason;
            
        }

        //public static string Season(int BirthMonth)
        //{

        //    string strSeason;
        //    //Incomplete Try Catch 
         
            
        //        try
        //        {
        //        if (BirthMonth > 12);
        //        }

        //        catch (IndexOutOfRangeException ex)
        //        {
                
        //        Console.WriteLine("Please enter a month between 1 and 12");
        //         }
        //        catch (Exception e)
        //        {

        //        Console.WriteLine("The content you have entered is invalid");
        //        }
               
            

        //    if (BirthMonth == 12 || BirthMonth == 1 || BirthMonth == 2)
        //    {
        //        strSeason = "Winter";
        //    }
        //    else if (BirthMonth == 3 || BirthMonth == 4 || BirthMonth == 5)
        //    {

        //        strSeason = "Spring";
        //    }
        //    else if (BirthMonth == 6 || BirthMonth == 7 || BirthMonth == 8)
        //    {

        //        strSeason = "Summer";
        //    }
        //    else if (BirthMonth == 9 || BirthMonth == 10 || BirthMonth == 11)
        //    {
        //        strSeason = "Autumn";
        //    }
        //    else
        //    {


        //        strSeason = "The month should be between 1 and 12";
        //    }


        //    return strSeason;
        //}


        
        //public static void CountBythMonthBySeason(List<Student> inClassMates)

        //{
        //    int intCountWinter= 0;
        //    int intCountSpring = 0;
        //    int intCountSummer = 0;
        //    int intCountAutumn = 0;

        //    foreach (var item in inClassMates)
        //    {
        //        switch (Student.Season(item.BirthMonth))
        //        {

        //            case "Winter":
        //                intCountWinter = intCountWinter + 1;
        //                break;
        //            case "Spring":
        //                intCountSpring++;
        //                break;
        //            case "Summer":
        //                intCountSummer++;

        //                break;

        //            case "Autumn":
        //                intCountAutumn++;

        //                break;

        //            default:
        //                Console.WriteLine("balalala");
        //                break;

                       
        //        }
        //    }
        //    Console.WriteLine("In winter there are {0} students who have a birthday" , intCountWinter);
        //    Console.WriteLine("In spring there are {0} students who have a birthday", intCountSpring);
        //    Console.WriteLine("In summer there are {0} students who have a birthday", intCountSummer);
        //    Console.WriteLine("In autumn there are {0} students who have a birthday", intCountAutumn);
        //}


    }
}
