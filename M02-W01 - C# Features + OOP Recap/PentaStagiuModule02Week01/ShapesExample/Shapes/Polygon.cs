using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesExample.Shapes
{
    public abstract class Polygon : Shape
    {
        protected List<double> sides;

        public Polygon(int numberOfSides)
        {
            sides = new List<double>(numberOfSides);
        }

        public Polygon(List<double> sides)
        {
            this.sides = sides;
        }

        public override double GetPerimeter()
        {
            double sum = 0;
            foreach (double side in sides)
            {
                sum += side;
            }
            return sum;
        }
    }
}
