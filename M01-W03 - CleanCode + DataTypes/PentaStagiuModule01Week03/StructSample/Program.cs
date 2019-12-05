using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructSample
{
    public struct Point3D
    {
        public double X;
        public double Y;
        public double Z;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Point3D pt = new Point3D();
            Console.WriteLine($"Point: x={pt.X} y={pt.Y} z={pt.Z}");
        }
    }
}
