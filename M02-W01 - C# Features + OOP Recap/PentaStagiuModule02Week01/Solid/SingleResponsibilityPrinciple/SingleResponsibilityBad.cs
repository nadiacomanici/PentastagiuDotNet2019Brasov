using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Solid.SingleResponsibilityPrincipleBad
{
    class Circle
    {
        public double Radius { get; set; }

        public void Print()
        {
            Console.WriteLine("Circle with radius {0}", Radius);
        }

        public void SaveToFile(string filename)
        {
            using (FileStream stream = File.Open(filename, FileMode.Create))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, this);
            }
        }
    }

    class Rectangle
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public void Print()
        {
            Console.WriteLine("Rectangle with width {0} and height {1}", Width, Height);
        }

        public void SaveToFile(string filename)
        {
            using (FileStream stream = File.Open(filename, FileMode.Create))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, this);
            }
        }
    }
}
