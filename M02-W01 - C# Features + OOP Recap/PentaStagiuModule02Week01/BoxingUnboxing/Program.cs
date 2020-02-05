using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingUnboxing
{
    class Program
    {
        static void FirstExample()
        {
            int i = 123;
            object o = i; // boxing
            int j = (int)o; //unboxing

            Console.WriteLine("### FirstExample ###");
            Console.WriteLine(o);
            Console.WriteLine(j);
        }

        static void SecondExample()
        {

            int i = 123;
            object o = i;

            Console.WriteLine("\n### SecondExample ###");

            if (o is int)
            {
                Console.WriteLine("The object contains an int");
            }
        }

        static void ThirdExample()
        {
            int i = 123;
            object o = i;
            i = 124;

            Console.WriteLine("\n### ThirdExample ###");
            Console.WriteLine(i); // 124
            Console.WriteLine((int)o); // 123
        }

        static void Main(string[] args)
        {
            FirstExample();
            SecondExample();
            ThirdExample();
        }
    }
}
