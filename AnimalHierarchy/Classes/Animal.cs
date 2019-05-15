using AnimalHierarchy.Interfaces;

namespace AnimalHierarchy.Classes
{
    public abstract class Animal : ISound
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public enum Sex { Male, Female };
        protected string sex;
        public abstract void ProduceSound();

        public Animal(string name, int age, Sex sex)
        {
            Name = name;
            Age = age;
            this.sex = sex.ToString();
        }

        public string GetSex()
        {
            return sex;
        }
    }
}
