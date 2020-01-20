using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.LiskovSubstitutionPrincipleBad
{
    class Rectangle
    {
        private double _width;

        public virtual double Width
        {
            get { return _width; }
            set { _width = value; }
        }

        private double _height;

        public virtual double Height
        {
            get { return _height; }
            set { _height = value; }
        }

        public double GetArea()
        {
            return Width * Height;
        }
    }

    class Square : Rectangle
    {
        public override double Width
        {
            get { return base.Width; }
            set { base.Width = value; base.Height = value; }
        }

        public override double Height
        {
            get { return base.Height; }
            set { base.Width = value; base.Height = value; }
        }
    }

    class AreaTester
    {
        public void VerifyArea(Rectangle r)
        {
            r.Width = 4;
            r.Height = 5;

            if (r.GetArea() != 20)
            {
                Console.WriteLine("Error!");
            }
        }
    }
}
