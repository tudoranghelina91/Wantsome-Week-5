namespace AnimalHierarchy.Classes
{
    public class Tomcat : Cat
    {
        public Tomcat(string name, int age) : base(name, age)
        {
            sex = Sex.Male.ToString();
        }
    }
}
