using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shapes.Classes;
using IODS.Handlers;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = new Shape[]
            {
                new Square(5.1f),
                new Rectangle(1, 4),
                new Triangle(5,5),
                new Rectangle(6, 5),
                new Square(3),
                new Triangle(2, 8)
            };

            foreach(Shape shape in shapes)
            {
                OutputHandling.Message(shape.Surface.ToString());
            }

            Console.ReadKey();
        }
    }
}
