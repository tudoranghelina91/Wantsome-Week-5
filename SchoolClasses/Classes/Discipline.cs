using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolClasses.Interfaces;

namespace SchoolClasses.Classes
{
    public class Discipline : IName, IComments
    {
        public string Name { get; set; }
        public int NumberOfLectures { get; set; }
        public int NumberOfExercises { get; set; }
        public string Comments { get; set; }
        public Discipline()
        {

        }

        public Discipline(string name)
        {
            Name = name;
        }
    }
}
