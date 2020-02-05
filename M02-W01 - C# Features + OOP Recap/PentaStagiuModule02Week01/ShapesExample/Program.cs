using ShapesExample.Shapes;
using System;
using System.Collections.Generic;

namespace ShapesExample
{
    class Program
    {
        private static List<Shape> _shapes = new List<Shape>();

        static void ReadShapes()
        {
            _shapes.Add(new Circle(4));
            _shapes.Add(new Ellipse(4, 5));
            _shapes.Add(new Rectangle(1, 2));
            _shapes.Add(new Triangle(2, 3, 4));
            _shapes.Add(new Square(4));
        }

        static void Main(string[] args)
        {
            ReadShapes();

            foreach (Shape s in _shapes)
            {
                Console.WriteLine($"{s.Name} P={s.GetPerimeter()} A={s.GetArea()}");
            }
        }
    }
}
