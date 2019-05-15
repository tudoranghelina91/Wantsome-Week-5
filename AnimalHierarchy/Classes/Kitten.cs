namespace AnimalHierarchy.Classes
{
    public class Kitten : Cat
    {
        public Kitten(string name, int age) : base(name, age)
        {
            sex = Sex.Female.ToString();
        }
    }
}
