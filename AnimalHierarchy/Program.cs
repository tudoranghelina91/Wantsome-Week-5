using System;
using AnimalHierarchy.Classes;

namespace AnimalHierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            AnimalsAges.SumOfAges(AnimalsStruct.animals1);
            AnimalsAges.SumOfAges(AnimalsStruct.animals2);
            AnimalsAges.SumOfAges(AnimalsStruct.animals3);
            AnimalsAges.PrintAverage();
            Console.ReadKey();
        }
    }
}
