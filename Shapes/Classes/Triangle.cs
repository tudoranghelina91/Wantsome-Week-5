using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Classes
{
    public class Triangle : Shape
    {
        public Triangle(float width, float height) : base(width, height)
        {
            Surface = CalculateSurface(width, height);
        }

        public override float CalculateSurface(float width, float height)
        {
            return height * width / 2;
        }
    }
}
