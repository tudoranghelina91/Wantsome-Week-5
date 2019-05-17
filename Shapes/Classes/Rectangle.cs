namespace Shapes.Classes
{
    public class Rectangle : Shape
    {
        public Rectangle(float width, float height) : base(width, height)
        {
            
        }

        public override float CalculateSurface()
        {
            return Width * Height;
        }
    }
}
