using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesExample.Shapes
{
    public abstract class Shape
    {
        public virtual string Name
        {
            get
            {
                return GetType().Name;
            }
        }

        public virtual double GetPerimeter()
        {
            return 0.2;
        }
        public abstract double GetArea();

        public double GetSomething()
        {
            return .0;
        }
    }
}
