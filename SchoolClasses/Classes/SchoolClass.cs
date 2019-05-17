using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolClasses.Interfaces;

namespace SchoolClasses.Classes
{
    public class SchoolClass : IName, IComments
    {
        public string Name { get; set; }
        public List<Student> Students { get; set; } = new List<Student>();
        public List<Teacher> Teachers { get; set; } = new List<Teacher>();
        public string Comments { get; set; }
        static int ID = 0;

        public SchoolClass()
        {
            Name = "CL" + (++ID);
        }
    }
}
