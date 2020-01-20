using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicExample
{
    class Cat
    {
        public void MakeNoise()
        {
            Console.WriteLine("Meow!");
        }
    }

    class Dog
    {
        public void MakeNoise()
        {
            Console.WriteLine("Bark!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            dynamic c = new Cat();
            dynamic d = new Dog();

            c.MakeNoise();
            d.MakeNoise();

            List<dynamic> animals = new List<dynamic>() { c, d };

            foreach (var animal in animals)
            {
                animal.MakeNoise();
            }
        }
    }
}
