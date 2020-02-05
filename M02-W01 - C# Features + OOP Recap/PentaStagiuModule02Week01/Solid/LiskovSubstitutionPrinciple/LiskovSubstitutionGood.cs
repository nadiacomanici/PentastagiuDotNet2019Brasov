using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.LiskovSubstitutionPrinciple
{
    abstract class Shape
    {
        public abstract double GetArea();
    }

    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public override double GetArea() { return Width * Height; }
    }

    class Square : Shape
    {
        public double Side { get; set; }
        public override double GetArea() { return Side * Side; }
    }

    class AreaTester
    {
        public void VerifyArea()
        {
            Shape r = new Rectangle() { Width = 3, Height = 4 };
            Shape s = new Square() { Side = 5 };

            if (r.GetArea() != 12)
            {
                Console.WriteLine("Error!");
            }

            if (s.GetArea() != 25)
            {
                Console.WriteLine("Error!");
            }
        }
    }
}
