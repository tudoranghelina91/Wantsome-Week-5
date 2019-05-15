using System;
using AnimalHierarchy.Classes;
using System.Text;

namespace AnimalHierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            AnimalsAges.CalculateSum(AnimalsStruct.animals1);
            AnimalsAges.CalculateSum(AnimalsStruct.animals2);
            AnimalsAges.CalculateSum(AnimalsStruct.animals3);
            AnimalsAges.PrintAverage();
            Console.ReadKey();
        }
    }
}
