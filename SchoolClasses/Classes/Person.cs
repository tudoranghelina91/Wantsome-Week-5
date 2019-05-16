using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolClasses.Interfaces;

namespace SchoolClasses.Classes
{
    public abstract class Person : IName
    {
        public string Name { get; set; }
    }
}
