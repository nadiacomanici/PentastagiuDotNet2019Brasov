using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesExample.Shapes
{
    public class Ellipse : Shape
    {
        protected double radiusA;
        protected double radiusB;

        public Ellipse()
        {
        }

        public Ellipse(double radiusA, double radiusB)
        {
            this.radiusA = radiusA;
            this.radiusB = radiusB;
        }

        public override double GetPerimeter()
        {
            return 2 * Math.PI * Math.Sqrt((radiusA * radiusA + radiusB * radiusB) / 2);
        }

        public override double GetArea()
        {
            return Math.PI * radiusA * radiusB;
        }
    }
}
