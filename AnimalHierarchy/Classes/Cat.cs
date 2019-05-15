using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IODS.Handlers;

namespace AnimalHierarchy.Classes
{
    public class Cat : Animal
    {
        public Cat(string name, int age) : base(name, age)
        {

        }

        public override void ProduceSound()
        {
            OutputHandling.Message("Meow!!!");
        }
    }
}
