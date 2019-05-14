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
        public List<Discipline> Disciplines { get; set; } = new List<Discipline>();
        public string Comments { get; set; }
        public Teacher(string name, List<Discipline> disciplines)
        {
            Name = name;
            Disciplines = disciplines;
        }

        public void Teach(Discipline discipline)
        {
            Discipline disc = Disciplines.Find(d => d == discipline);
            if (disc != null)
            {
                OutputHandling.Message($"Teaching {discipline}", consoleColor: ConsoleColor.Green);
            }

            else
            {
                OutputHandling.Message($"Sorry, but I am not lisenced to teach {discipline}");
            }
        }
    }
}
