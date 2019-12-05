using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLanguage.Topics
{
    class DefiningMethods
    {
        public static void Run()
        {
            AddNumbers(1, 2);
        }

        static void AddNumbers(int a, int b)
        {
            int result = a + b;
            Console.WriteLine("The result is {0}", result);
        }
    }
}
