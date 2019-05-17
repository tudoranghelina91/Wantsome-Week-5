using System;
using System.Text;
using Shapes.Classes;
using IODS.Handlers;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8; // for printing meters square
            const string SQRMTR = " m\u00b3";

            foreach(Shape shape in ShapeStruct.shapes)
            {
                OutputHandling.Message(shape.CalculateSurface() + SQRMTR);
            }

            Console.ReadKey();
        }
    }
}
