using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesExample.Shapes
{
    public class Triangle : Polygon
    {
        public Triangle() : base(3)
        {
        }

        public Triangle(double sideA, double sideB, double sideC) 
            : base(new List<double>() { sideA, sideB, sideC })
        {
        }

        public override double GetPerimeter()
        {
            return sides[0] + sides[1] + sides[2];
        }

        public override double GetArea()
        {
            double s = GetPerimeter() / 2;
            double area = Math.Sqrt(s * (s - sides[0]) * (s - sides[1]) * (s - sides[2]));
            return area;
        }
    }
}
