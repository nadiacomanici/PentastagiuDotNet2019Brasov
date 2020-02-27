using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesExample.Shapes
{
    public class Rectangle : Polygon
    {
        public Rectangle() : base(4)
        {
        }

        public Rectangle(double width, double height) 
            : base(new List<double>() { width, height, width, height })
        {
        }

        public double GetPerimeter()
        {
            return 2 * (sides[0] + sides[1]);
        }

        public override double GetArea()
        {
            return sides[0] * sides[1];
        }
    }
}
