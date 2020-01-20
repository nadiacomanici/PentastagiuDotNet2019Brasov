using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.OpenClosedPrincipleBad
{
    class Circle
    {
        public double Radius { get; set; }
    }

    class Rectangle
    {
        public double Width { get; set; }
        public double Height { get; set; }
    }

    class AreaCalculator
    {
        public double CalculateArea(object shape)
        {
            if (shape is Circle)
            {
                Circle circle = (Circle)shape;
                return Math.PI * circle.Radius * circle.Radius;
            }
            else if (shape is Rectangle)
            {
                Rectangle rectangle = (Rectangle)shape;
                return rectangle.Width * rectangle.Height;
            }
            else
            {
                return 0;
            }
        }
    }
}
