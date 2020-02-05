using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesExample.Shapes
{
    public class Square : Polygon
    {
        public Square() : base(4)
        {

        }

        public Square(double side) : base(new List<double>() { side, side, side, side })
        {

        }

        public override double GetPerimeter()
        {
            return 4 * sides[0];
        }

        public override double GetArea()
        {
            return sides[0] * sides[0];
        }
    }
}
