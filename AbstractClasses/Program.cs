using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractClasses.Classes;
using IODS.Handlers;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Cheetah cheetah1 = new Cheetah();
            Monkey monkey1 = new Monkey();

            OutputHandling.Message($"Animal: {cheetah1}");
            OutputHandling.Message($"Name: {cheetah1.GetName()}");
            OutputHandling.Message($"Speed: {cheetah1.Speed}");
            OutputHandling.Message($"Animal: {monkey1}");
            OutputHandling.Message($"Name: {monkey1.GetName()}");
            OutputHandling.Message($"Speed: {monkey1.Speed}");

            Console.ReadKey();
        }
    }
}
