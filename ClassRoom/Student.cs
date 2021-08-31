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

        public static string Season(int BirthMonth)
        {
         
            string strSeason;
      
         
                if (BirthMonth == 12 || BirthMonth == 1 || BirthMonth == 2)
                {
                    strSeason = "Winter";
                }
                else if (BirthMonth == 3 || BirthMonth == 4 || BirthMonth == 5)
                {
                
                    strSeason = "Spring";
                }
                else if (BirthMonth == 6 || BirthMonth == 7 || BirthMonth == 8)
                {
             
                    strSeason = "Summer";
                }
                else if (BirthMonth == 9 || BirthMonth == 10 || BirthMonth == 11)
                {
                    strSeason = "Autumn";
                }
                else
                {
                
                
                    strSeason = "Unkown";
               }
            
            
            return strSeason;
        }
    }
}
