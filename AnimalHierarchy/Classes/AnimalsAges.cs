using System;
using IODS.Handlers;

namespace AnimalHierarchy.Classes
{
    public static class AnimalsAges
    {
        private static float catAge = 0;
        private static float frogAge = 0;
        private static float dogAge = 0;

        private static int catAgeCnt = 0;
        private static int frogAgeCnt = 0;
        private static int dogAgeCnt = 0;

        public static void SumOfAges(Animal[] animals)
        {
            foreach (Animal animal in animals)
            {
                if (animal is Cat)
                {
                    catAge += animal.Age;
                    catAgeCnt++;
                }

                else if (animal is Frog)
                {
                    frogAge += animal.Age;
                    frogAgeCnt++;
                }

                else if (animal is Dog)
                {
                    dogAge += animal.Age;
                    dogAgeCnt++;
                }
            }
        }

        public static void PrintAverage()
        {
            OutputHandling.Message(String.Format("Average of cat ages: {0:F2} years",(catAge / catAgeCnt)));
            OutputHandling.Message(String.Format("Average of frog ages: {0:F2} years", (frogAge / frogAgeCnt)));
            OutputHandling.Message(String.Format("Average of dog ages: {0:F2} years", (dogAge / dogAgeCnt)));
        }
    }
}
