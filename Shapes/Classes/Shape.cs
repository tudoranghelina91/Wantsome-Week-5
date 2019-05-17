using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Classes
{
    public abstract class Shape
    {
        public abstract float CalculateSurface(float width, float height);
        protected float Width { get; set; }
        protected float Height { get; set; }
        public float Surface { get; set; }

        protected Shape(float width, float height)
        {
            Width = width;
            Height = height;
        }
    }
}
