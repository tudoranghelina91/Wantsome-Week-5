using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces1.Classes;

namespace Interfaces1
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape square = new Shape(12, 12);
            square.SetPosition(3, 7);
            square.Print();
            Console.ReadKey();
        }
    }
}
