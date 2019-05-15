using System;
using IODS.Handlers;

namespace AnimalHierarchy.Classes
{
    public static class AnimalsAges
    {
        private static int catAge = 0;
        private static int frogAge = 0;
        private static int dogAge = 0;

        private static int cats = 0;
        private static int frogs = 0;
        private static int dogs = 0;

        public static void CalculateSum(Animal[] animals)
        {
            foreach (Animal animal in animals)
            {
                if (animal is Cat)
                {
                    catAge += animal.Age;
                    cats++;
                }

                else if (animal is Dog)
                {
                    dogAge += animal.Age;
                    dogs++;
                }

                else if (animal is Frog)
                {
                    frogAge += animal.Age;
                    frogs++;
                }
            }
        }

        public static void PrintAverage()
        {
            OutputHandling.Message(String.Format("Average of cat ages: {0:F1} years",(catAge / cats)));
            OutputHandling.Message(String.Format("Average of frog ages: {0:F1} years", (frogAge / frogs)));
            OutputHandling.Message(String.Format("Average of dog ages: {0:F1} years", (dogAge / dogs)));
        }
    }
}
