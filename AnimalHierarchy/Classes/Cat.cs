using IODS.Handlers;

namespace AnimalHierarchy.Classes
{
    public abstract class Cat : Animal
    {
        public Cat(string name, int age, Sex sex = 0) : base(name, age, sex)
        {
            
        }

        public override void ProduceSound()
        {
            OutputHandling.Message("Meow!!!");
        }
    }
}
