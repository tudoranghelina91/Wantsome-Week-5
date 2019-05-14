using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses.Classes
{
    public abstract class Animal
    {
        // Abstract methods
        public abstract string GetName();
        public abstract int Speed { get;  }
        private string color;
        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public string Color2 { get; set; }

        public override bool Equals(object obj)
        {
            if (obj is Animal)
                return GetName() == ((Animal)obj).GetName();
            //sau return GetName() == (obj as Animal).GetName();

            return false;
        }
    }
}
