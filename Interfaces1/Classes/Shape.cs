using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces1.Interfaces;
using Handlers;

namespace Interfaces1.Classes
{
    class Shape : IShape
    {
        public int Width {get; set;}
        public int Height { get; set; }

        public Shape(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public void SetPosition(int x, int y)
        {
            OutputHandling.Message($"Position set at coords {x}, {y}");
        }

        public int CalculateSurface()
        {
            return Width * Height;
        }

        public void Print()
        {
            OutputHandling.Message($"Size: {Width} x {Height} = {CalculateSurface()}");
        }
    }
}
