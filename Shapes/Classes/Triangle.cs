namespace Shapes.Classes
{
    public class Triangle : Shape
    {
        public Triangle(float width, float height) : base(width, height)
        {
            
        }

        public override float CalculateSurface()
        {
            return Height * Width / 2;
        }
    }
}
