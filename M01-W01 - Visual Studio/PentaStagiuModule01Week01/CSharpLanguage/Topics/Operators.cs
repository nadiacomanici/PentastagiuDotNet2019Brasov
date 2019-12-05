using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLanguage.Topics
{
    class Operators
    {
        public static void Run()
        {
            int x = 5;
            int y = 6;

            int sum = x + y;
            int dif = x - y;
            int mul = x * y;
            int div = x / y;

            Console.WriteLine("The value of sum is {0}", sum);
            Console.WriteLine("The value of dif is {0}", dif);
            Console.WriteLine("The value of mul is {0}", mul);
            Console.WriteLine("The value of div is {0}", div);
        }
    }
}
