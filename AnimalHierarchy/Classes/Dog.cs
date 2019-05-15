using IODS.Handlers;

namespace AnimalHierarchy.Classes
{
    public class Dog : Animal
    {
        public Dog(string name, int age, Sex sex = Sex.Male) : base (name, age, sex)
        {

        }

        public override void ProduceSound()
        {
            OutputHandling.Message("Woof! Woof!");
        }
    }
}
