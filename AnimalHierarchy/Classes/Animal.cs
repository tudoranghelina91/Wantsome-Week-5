using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalHierarchy.Interfaces;

namespace AnimalHierarchy.Classes
{
    public abstract class Animal : ISound
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public abstract void ProduceSound();

        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
