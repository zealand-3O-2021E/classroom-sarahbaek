using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Collections;

namespace ClassRoom
{
    public class ClassRoom
    {
        private string _className;
        private List<Student> _classList;
        private DateTime _semesterStart;

        //Default constructor
        public ClassRoom()
        {

        }

        public string ClassName { get => _className; set => _className = value; }
        public List<Student> ClassList { get => _classList; set => _classList = value; }
        public DateTime SemesterStart { get => _semesterStart; set => _semesterStart = value; }
    }
}
