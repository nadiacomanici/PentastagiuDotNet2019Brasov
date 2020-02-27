using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Solid.SingleResponsibilityPrincipleGood
{
    abstract class Shape
    {
    }

    class Circle : Shape
    {
        public double Radius { get; set; }
    }

    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
    }

    class ShapePrinter
    {
        public void Print(Circle circle)
        {
            Console.WriteLine("Circle with radius {0}", circle.Radius);
        }

        public void Print(Rectangle rectangle)
        {
            Console.WriteLine("Rectangle with width {0} and height {1}", rectangle.Width, rectangle.Height);
        }
    }

    class ShapeSerializer
    {
        public void SaveToFile(string filename, Shape s)
        {
            using (FileStream stream = File.Open(filename, FileMode.Create))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, s);
            }
        }
    }
}
