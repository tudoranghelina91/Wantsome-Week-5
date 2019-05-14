using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolClasses.Interfaces;

namespace SchoolClasses.Classes
{
    public class School : IName
    {
        public string Name { get; set; }
        public List<SchoolClass> SchoolClassesList {get; set;} = new List<SchoolClass>();
        
        public School(string name)
        {
            Name = name;
        }

        public School(string name, List<SchoolClass> schoolClasses)
        {
            Name = name;
            SchoolClassesList = schoolClasses;
        }
    }
}
