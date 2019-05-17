namespace Shapes.Classes
{
    public abstract class Shape
    {
        public abstract float CalculateSurface();
        protected float Width { get; set; }
        protected float Height { get; set; }

        protected Shape(float width, float height)
        {
            Width = width;
            Height = height;
        }
    }
}
