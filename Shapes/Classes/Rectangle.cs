﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Classes
{
    public class Rectangle : Shape
    {
        public Rectangle(float width, float height) : base(width, height)
        {
            Surface = CalculateSurface(width, height);
        }

        public override float CalculateSurface(float width, float height)
        {
            return width * height;
        }
    }
}