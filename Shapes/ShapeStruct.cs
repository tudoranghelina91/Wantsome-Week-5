using Shapes.Classes;

namespace Shapes
{
    struct ShapeStruct
    {
        public static Shape[] shapes = new Shape[] {
            new Square(5.1f),
            new Rectangle(1, 4),
            new Triangle(5,5),
            new Rectangle(6, 5),
            new Square(3),
            new Triangle(2, 8)
        };
    }
}
