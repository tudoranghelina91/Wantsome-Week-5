using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolClasses.Interfaces;

namespace SchoolClasses.Classes
{
    public class Student : Person, IComments
    {
        public static int ID { get; set; }
        public override string Name { get; set; }
        public string Comments { get; set; }
        private static int id = 0;

        public Student(string name)
        {
            Name = name;
            ID = id++;
        }
    }
}
