using IODS.Handlers;

namespace AnimalHierarchy.Classes
{
    public class Frog : Animal
    {
        public Frog(string name, int age, Sex sex = Sex.Male) : base(name, age, sex)
        {
            
        }

        public override void ProduceSound()
        {
            OutputHandling.Message("Ribbit!");
        }
    }
}
