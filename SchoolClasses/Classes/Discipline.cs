using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolClasses.Interfaces;

namespace SchoolClasses.Classes
{
    public class Discipline : IName
    {
        public string Name { get; set; }

        public Discipline()
        {

        }

        public Discipline(string name)
        {
            Name = name;
        }
    }
}
