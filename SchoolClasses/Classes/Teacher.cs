using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolClasses.Interfaces;
using IODS.Handlers;

namespace SchoolClasses.Classes
{
    public class Teacher : Person, IComments
    {
        public override string Name { get; set; }
        public List<Discipline> Disciplines { get; set; }
        public string Comments { get; set; }
        public Teacher(string name, List<Discipline> disciplines)
        {
            Name = name;
            Disciplines = disciplines;
        }

        public static void Teach(Discipline discipline)
        {
            OutputHandling.Message($"Teaching {discipline.Name}");
        }
    }
}
