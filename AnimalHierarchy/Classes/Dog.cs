using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IODS.Handlers;

namespace AnimalHierarchy.Classes
{
    public class Dog : Animal
    {
        public Dog(string name, int age, string sex) : base (name, age)
        {
            Sex = sex;
        }

        public override void ProduceSound()
        {
            OutputHandling.Message("Woof! Woof!");
        }
    }
}
