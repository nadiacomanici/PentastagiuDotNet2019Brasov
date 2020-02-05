using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesExample.Shapes
{
    public class Circle : Ellipse
    {
        public Circle() : base()
        {
        }

        public Circle(double radius) : base(radius, radius)
        {
        }

        public override double GetPerimeter()
        {
            return 2 * Math.PI * radiusA;
        }
    }
}
