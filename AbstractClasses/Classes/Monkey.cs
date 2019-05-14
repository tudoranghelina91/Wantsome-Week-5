using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses.Classes
{
    public class Monkey : Animal
    {
        public override int Speed { get { return 45; } }
        public override string GetName()
        {
            return "Banana Joe";
        }
    }
}
