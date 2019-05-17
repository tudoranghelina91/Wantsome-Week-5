using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Classes
{
    public class Square : Rectangle
    {
        public Square(float width) : base(width, width)
        {
            Surface = base.CalculateSurface(width, width);
        }
    }
}
