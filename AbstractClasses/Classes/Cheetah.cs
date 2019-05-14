using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses.Classes
{
    public class Cheetah : Animal
    {
        public override int Speed { get { return 120; } }
        public override string GetName()
        {
            return "Cheetutza";
        }
    }
}
